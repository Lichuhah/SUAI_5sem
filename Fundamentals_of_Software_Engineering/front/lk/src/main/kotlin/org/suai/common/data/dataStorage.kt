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
open class dataStorage {
    open val students     = mutableListOf<studentModel>  ()  // список всех стдентов известных клиенту
    open val lecturers    = mutableListOf<lecturerModel> ()  // список всех преподавателей известных клиенту
    open val deanats      = mutableListOf<deanatModel>   ()  // список всех сотрудников деканата
    open val groups       = mutableListOf<groupModel>    ()  // список всех групп известных клиенту
    open val tasks        = mutableListOf<taskModel>     ()  // список всех заданий известных клиенту
    open val docs         = mutableListOf<docModel>      ()  // список всех материалов известных клиенту
}