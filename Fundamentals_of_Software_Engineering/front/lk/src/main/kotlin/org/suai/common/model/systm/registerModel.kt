package org.suai.common.model.systm

/**
 * @param loginManager логин
 * @param password пароль
 * @param first_name имя
 * @param second_name фамилия
 * @param other_Name отчество (может быть null)
 * **/
data class registerModel(
    val loginManager: String,
    val password    : String,
    val first_name  : String,
    val second_name : String,
    val other_Name  : String?
)