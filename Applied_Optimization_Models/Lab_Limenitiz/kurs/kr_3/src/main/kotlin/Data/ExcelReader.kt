package Data

import org.apache.poi.hssf.usermodel.HSSFWorkbook;
import org.apache.poi.ss.usermodel.*
import org.apache.poi.ss.util.NumberToTextConverter;
import org.apache.poi.xssf.usermodel.XSSFWorkbook;
import repository.ProgrammerRepository
import repository.ExpensesRepository
import repository.IncomeRepository

import java.io.File;
import java.io.FileInputStream;
import java.util.ArrayList;
import java.util.HashMap;

object ExcelReader {
    // Чтение файла
    fun read(filename: String = "calc.xlsx") {
        val workbook = loadWorkbook(filename)
        val sheetIterator = workbook?.sheetIterator()
        if (sheetIterator != null) {
            while (sheetIterator.hasNext()) {
                val sheet: Sheet = sheetIterator.next()
                processSheet(sheet)
                println()
            }
        }
        else
            println("sheetIterator is null")
    }

    // Загруска файла
    private fun loadWorkbook(filename: String): Workbook? {
        val extension = filename.substring(filename.lastIndexOf(".") + 1)
        val file = FileInputStream(File(filename))
        return when (extension) {
            "xls" ->  HSSFWorkbook(file)
            "xlsx" -> XSSFWorkbook(file)
            else -> {
                println("Unknown Excel file extension: $extension")
                null
            }
        }
    }

    // Обработка строки
    private fun processSheet(sheet: Sheet) {
        println("Sheet: " + sheet.getSheetName())
        val data = HashMap<Int, MutableList<Any>>()
        val iterator = sheet.rowIterator()
        var rowIndex = 0
        while (iterator.hasNext()) {
            val row = iterator.next()
            processRow(data, rowIndex, row)
            rowIndex++
        }

        ProgrammerRepository.data.clear()
        ExpensesRepository.data.clear()
        IncomeRepository.data.clear()

        for ((k,v) in data)
            when ( k ) {
                1 -> for (i in 1..6) ProgrammerRepository.data.add(v[i]
                    .toString().toInt())
                2 -> for (i in 1..6) ExpensesRepository.data.add(v[i]
                    .toString().replace(',', '.').toDouble())
                3 -> for (i in 1..6) IncomeRepository.data.add(v[i]
                    .toString().replace(',', '.').toDouble())
                else -> {}
             }

        print("Sheet data:")
        println(data)

        println(ExpensesRepository.data.toString())
        println(ProgrammerRepository.data.toString())
        println(IncomeRepository.data.toString())
    }

    // Обработка строки
    private fun processRow(data: HashMap<Int, MutableList<Any>>, rowIndex: Int, row: Row) {
        data[rowIndex] = ArrayList()
        for (cell in row) {
            processCell(cell, data[rowIndex]!!)
        }
    }

    // Обработка ячейки
    private fun processCell(cell: Cell, dataRow: MutableList<Any>) {
        when (cell.cellType) {
            CellType.STRING -> dataRow.add(cell.stringCellValue)
            CellType.NUMERIC -> if (DateUtil.isCellDateFormatted(cell)) {
                dataRow.add(cell.localDateTimeCellValue)
            } else {
                dataRow.add(NumberToTextConverter.toText(cell.numericCellValue))
            }
            CellType.BOOLEAN -> dataRow.add(cell.booleanCellValue)
            CellType.FORMULA -> dataRow.add(cell.cellFormula)
            else -> dataRow.add(" ")
        }
    }
}