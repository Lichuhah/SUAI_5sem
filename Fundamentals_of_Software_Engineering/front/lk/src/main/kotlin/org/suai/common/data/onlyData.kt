package org.suai.common.data

import org.suai.common.model.*
import org.suai.common.model.role.deanatModel
import org.suai.common.model.role.lecturerModel
import org.suai.common.model.role.studentModel
import org.suai.common.model.role.userModel

/**
 * синглтон для хранения данных, локальная замена БД
 * студент: все задания для меня
 * препод
 */
open class onlyData {
    open val groups       = mutableListOf<groupModel>       ()  // список всех групп известных клиенту
    open val tasks        = mutableListOf<taskModel>        ()  // список всех заданий известных клиенту
    open val students     = mutableListOf<studentModel>     ()  // список всех стдентов известных клиенту
    open val discipline   = mutableListOf<disciplineModle>  ()  // список всех предметов известных клиенту
    open val docs         = mutableListOf<docModel>         ()  // список всех материалов известных клиенту
    open val lecturers    = mutableListOf<lecturerModel>    ()  // список всех преподавателей известных клиенту
    open val speciality   = mutableListOf<specialityModel>  ()  // список всех специальностей известных клиенту
    open val completeTasks= mutableListOf<completeTaskModel>()  // список всех выполненых заданий известных клиенту
    open val deanatWorkers= mutableListOf<deanatModel>      ()  // список всех сотрудников деканата известных клиенту
}