package org.suai.common.model

/**
 * @param number номер группы
 * @param id id группы
 * @param listStudentId список id студентво состоящих в этой группе
 * @param course курс (количество лет от поступления)
 * @param count колличество студентов в группе
 */
data class groupModel(
    override val id:             Int                     = -1,
    val number:         String                  = "",
    val listStudentId:  MutableList<Int>        = mutableListOf(),
    val specialityId:   Int                     = 0,
    var course:         Int                     = 0
): uuId {
    val count : Int
        get() = listStudentId.size
}

//TODO: course?
// стоит ли эту штуку здесь фигачить? 
// обычто из номера группы можно достать (даже если это не гуап)