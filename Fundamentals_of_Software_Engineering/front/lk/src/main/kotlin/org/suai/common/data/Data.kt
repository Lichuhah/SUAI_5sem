package org.suai.common.data

import androidx.compose.runtime.mutableStateListOf
import org.suai.common.model.docModel
import org.suai.common.model.groupModel
import org.suai.common.model.role.lecturerModel
import org.suai.common.model.role.studentModel
import org.suai.common.model.taskModel

/** синглтон для хранения данных, локальная замена БД
 */
object Data {
    val student     = mutableStateListOf<studentModel>  ()  // список всех стдентов известных клиенту
    val lecturer    = mutableStateListOf<lecturerModel> ()  //
    val group       = mutableStateListOf<groupModel>    ()  //
    val task        = mutableStateListOf<taskModel>     ()  //
    val doc         = mutableStateListOf<docModel>      ()  //
}