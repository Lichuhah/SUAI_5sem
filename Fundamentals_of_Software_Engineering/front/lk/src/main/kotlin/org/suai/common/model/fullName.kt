package org.suai.common.model

/** ФИО
 *  @param first_name Имя
 *  @param second_name Фамилия
 *  @param other_name Отчество (может быть null)
 * **/
open class fullName(
    var first_name:     String,
    var second_name:    String,
    var other_name:     String?
)