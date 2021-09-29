package org.suai.common.model.role

/**
 * Модель преподавателя
 * @param position должность
 * @param listDisciplineId список id дисциплин
 */
data class lecturerModel(
    val position:           String,
    val listDisciplineId:   MutableList<Int> = mutableListOf()  ,
) : userModel()
