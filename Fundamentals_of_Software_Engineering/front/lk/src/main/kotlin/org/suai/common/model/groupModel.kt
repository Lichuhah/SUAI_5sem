package org.suai.common.model

/**
 * @param number номер группы
 * @param id id группы
 * @param listStudentId список id студентво состоящих в этой группе
 * @param listTaskId список id заданий
 * @param listDocId список id материалов
 * @param listDisciplineId список id предметов
 * @param course курс (количество лет от поступления)
 * @param count колличество студентов в группе
 */
data class groupModel(
    override val id:        Int,
    val number:             String,
    val listStudentId:      MutableList<Int> = mutableListOf(),
    val listTaskId:         MutableList<Int> = mutableListOf(),
    val listDocId:          MutableList<Int> = mutableListOf(),
    val listDisciplineId:   MutableList<Int> = mutableListOf(),
    val specialityId:       Int,
    var course:             Int
): uuId {
    val count : Int
        get() = listStudentId.size
}

//TODO: course? 1, 2, 3...
// стоит ли эту штуку здесь фигачить? 
// обычто из номера группы можно достать (даже если это не гуап)

// а нахуя ?
// а почему бы и нет