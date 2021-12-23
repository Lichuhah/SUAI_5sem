package manager

import Data.Product
import repository.ProductRepository

object ProductManager {

    fun productFromString(inputList: MutableList<Any>) {
        if ( "Потребность".toRegex().containsMatchIn(inputList.toString()) ) {
            ProductRepository.data.clear()
            for (i in 0..6)
                ProductRepository.data.add(
                    Product(inputList[3 + i].toString().substringAfter(" ").toInt(), 0)
                )
        }
        else if ( "Стоимость".toRegex().containsMatchIn(inputList.toString()) )
            for (i in 0..6)
                ProductRepository.data[i].cost = inputList[3 + i].toString().toInt()
    }
}