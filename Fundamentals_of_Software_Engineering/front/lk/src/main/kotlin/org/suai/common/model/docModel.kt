package org.suai.common.model

import java.util.*

/**
 * модель документа (материал)
 * @param id id документа
 * @param disciplineId id предмета по которому этот материал
 * @param name имя материала
 * @param description оисание
 * @param date дата добавления
 */
data class docModel(
    override val id     : Int,
    val disciplineId    : Int,
    val name            : String,
    val description     : String,
    val date            : Date

) : uuId