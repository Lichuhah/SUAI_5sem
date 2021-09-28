package org.suai.common.model

/**
 * @param number номер группы
 * @param id id группы
 * @param listStudentId список id студентво состоящих в этой группе
 * @param course курс (количество лет от поступления)
 * @param count колличество студентов в группе
 */
data class groupModel(
    val number:         String                  = "",
    val id:             Int                     = -1,
    val listStudentId:  MutableList<Int>        = mutableListOf(),
    val specialityId:   Int                     = 0,
    var course:         Int                     = 0
) {
    val count : Int
        get() = listStudentId.size
}