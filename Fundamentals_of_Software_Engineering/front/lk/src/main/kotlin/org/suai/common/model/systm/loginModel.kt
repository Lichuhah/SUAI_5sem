package org.suai.common.model.systm

/**
 * Техническая модель для формирования запроса на сервер
 */
data class loginModel(
    val login: String,
    val password: String
    )