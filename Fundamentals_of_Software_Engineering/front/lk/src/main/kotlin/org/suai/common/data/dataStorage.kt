package org.suai.common.data

import androidx.compose.runtime.mutableStateListOf
import org.suai.common.model.docModel
import org.suai.common.model.groupModel
import org.suai.common.model.role.deanatModel
import org.suai.common.model.role.lecturerModel
import org.suai.common.model.role.studentModel
import org.suai.common.model.taskModel
import org.suai.common.model.uuId

/**
 * синглтон для хранения данных, локальная замена БД
 */
class dataStorage {
    val student     = mutableListOf<studentModel>  ()  // список всех стдентов известных клиенту
    val lecturer    = mutableListOf<lecturerModel> ()  // список всех преподавателей известных клиенту
    val deanat      = mutableListOf<deanatModel>   ()  // список всех сотрудников деканата
    val group       = mutableListOf<groupModel>    ()  // список всех групп известных клиенту
    val task        = mutableListOf<taskModel>     ()  // список всех заданий известных клиенту
    val doc         = mutableListOf<docModel>      ()  // список всех материалов известных клиенту
}