package manager

import Data.Line

object LineManager {
    /**
     * Превращение строки в объект линии
     */
    fun lineFormString(inputList: MutableList<Any>) : Line? {
        if ( "Линия".toRegex().containsMatchIn(inputList.toString()) ) {
            val name = inputList[1].toString()
            val list = mutableListOf<Double>()
            for (i in 0..6)
                list.add(  getDouble( inputList[3+i].toString() ) )
            val count = inputList[2].toString().substringAfter(" ").toInt()
            val cost = inputList[10].toString().toDouble()
            return Line(name, count, list[0],list[1],list[2],list[3],list[4],list[5],list[6], cost)
        }
        return null
    }

    private fun getDouble(str : String) =
        if ( str != "-" )
            str.toDouble()
        else
            9999.0
}