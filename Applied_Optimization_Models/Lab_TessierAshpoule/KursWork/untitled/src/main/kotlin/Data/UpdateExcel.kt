package Data

import org.apache.poi.ss.usermodel.Row
import org.apache.poi.ss.usermodel.Sheet
import org.apache.poi.xssf.usermodel.XSSFWorkbook
import repository.LineRepository
import repository.ProductRepository
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

        for (i in 0 until LineRepository.data.size) {
            val header: Row = sheet.getRow(2+i)
            var j = 1
            val name = if ( "Линия".toRegex().containsMatchIn(LineRepository.data[i].name) ) {
                LineRepository.data[i].name
            } else {
                "Линия ${LineRepository.data[i].name}"
            }
            header.getCell(j++).setCellValue(name)
            header.getCell(j++).setCellValue(LineRepository.data[i].count.toString())
            header.getCell(j++).setCellValue(LineRepository.data[i].tp1)
            header.getCell(j++).setCellValue(LineRepository.data[i].tp2)
            header.getCell(j++).setCellValue(LineRepository.data[i].tp3)
            header.getCell(j++).setCellValue(LineRepository.data[i].tp4)
            header.getCell(j++).setCellValue(LineRepository.data[i].tp5)
            header.getCell(j++).setCellValue(LineRepository.data[i].tp6)
            header.getCell(j++).setCellValue(LineRepository.data[i].tp7)
            header.getCell(j).setCellValue(LineRepository.data[i].cost)
        }

        val productLimit: Row = sheet.getRow(9)
        val productCost:  Row = sheet.getRow(10)
        for (i in 0 until ProductRepository.data.size ) {
            productLimit.getCell(3+i).setCellValue(ProductRepository.data[i].limit.toDouble())
            productCost .getCell(3+i).setCellValue(ProductRepository.data[i].cost.toDouble())
        }

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