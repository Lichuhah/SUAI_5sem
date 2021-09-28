package org.suai.common.utils

import org.suai.common.data.dataStorage
import org.suai.common.data.dataStorageSingleton
import org.suai.common.model.role.studentModel

/**
 * Заполнение тестовыми данными
 */
fun testData() {
    val data = dataStorageSingleton.getInstance()

    data.student.add(studentModel())
}