package org.suai.common.model

import org.suai.common.enum_.EXAM
import org.suai.common.model.role.lecturerModel

/**
 * Модель предмета
 * @param id
 * @param name
 * @param lecturerIdList список id преподавателей
 * @param exam тип атестации по предмету
 * @param hours количество часов отведённое на предмет
 */
data class disciplineModle(
    override val id:    Int,
    val name:           String,
    val lecturerIdList: MutableList<Int> = mutableListOf(),
    val exam:           EXAM,
    val hours:          Int
) : uuId