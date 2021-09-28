package org.suai.common.utils

import org.suai.common.data.onlyData
import org.suai.common.data.Storage
import org.suai.common.model.role.studentModel

/**
 * Заполнение тестовыми данными
 */
fun testData() {
    val data = Storage.getInstance()

    data.students.add(studentModel())
}