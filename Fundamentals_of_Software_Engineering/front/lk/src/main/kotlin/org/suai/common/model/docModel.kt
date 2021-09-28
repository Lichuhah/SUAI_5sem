package org.suai.common.model

import java.sql.Time

/**
 * модель документа (материал)
 * @param id id документа
 * @param disciplineId id предмета по которому этот материал
 * @param name имя материала
 * @param description оисание
 * @param date дата добавления
 */
data class docModel(
    override val id     : Int       = -1,
    val disciplineId    : Int       = 0,
    val name            : String    = "",
    val description     : String    = "",
    val date            : Time
) : uuId