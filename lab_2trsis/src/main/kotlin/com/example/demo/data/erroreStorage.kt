package com.example.demo.data

object erroreStorage {
    var lastError = ""

    /** сообщить о возникновении ошибки **/
    fun error(error: String) {
        println(error)
    }

    /** возвращает текст последней ошибки **/
    fun getError() = lastError
}