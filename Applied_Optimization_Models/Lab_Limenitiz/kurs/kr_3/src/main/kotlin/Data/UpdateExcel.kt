package Data

import org.apache.poi.ss.usermodel.Row
import org.apache.poi.xssf.usermodel.XSSFWorkbook
import repository.ProgrammerRepository
import repository.ExpensesRepository
import repository.IncomeRepository
import java.io.File
import java.io.FileInputStream
import java.io.FileOutputStream
import java.io.IOException
import java.util.*

object UpdateExcel {

    fun changeCalls() {

        val file = FileInputStream(File("calc.xlsx"))
        val workbook = XSSFWorkbook(file)
        val sheet = workbook.getSheetAt(0)

        val programmer: Row = sheet.getRow(1)
        for (i in 0 until ProgrammerRepository.data.size)
            programmer.getCell(1+i).setCellValue(ProgrammerRepository.data[i].toDouble())

        val expenses: Row = sheet.getRow(2)
        for (i in 0 until ExpensesRepository.data.size)
            expenses.getCell(1+i).setCellValue(ExpensesRepository.data[i])

        val income: Row = sheet.getRow(3)
        for (i in 0 until IncomeRepository.data.size)
            income.getCell(1+i).setCellValue(IncomeRepository.data[i])

        try {
            val out = FileOutputStream(File("calc.xlsx"))
            workbook.write(out)
            out.close()
            println("Значения успешно изменены")
        } catch (e: IOException) {
            e.printStackTrace()
        }
    }

    val checkedInputDigit: Double
        get() {
            val digit = Scanner(System.`in`).nextDouble()
            if (digit < 0) {
                println("Значения не могут быть отрицательными. Повторите попытку! : ")
                checkedInputDigit
            }
            return digit
        }
}