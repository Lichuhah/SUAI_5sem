package org.suai.common.utils

import org.suai.common.data.Storage
import org.suai.common.enum_.EDUCATION
import org.suai.common.enum_.EXAM
import org.suai.common.model.*
import org.suai.common.model.role.lecturerModel
import org.suai.common.model.role.studentModel
import java.util.*
import javax.xml.crypto.Data

/**
 * Заполнение тестовыми данными
 */
fun testData() {
    val data = Storage.getInstance()

    val student = studentModel(1)
    student.id         = 1
    student.login      = "vasa"
    student.mail       = "spam@mainl"
    student.name       = fullName("ivan", "ivanov", "ivanovich" )
    student.password   = "123456"
    student.phone      = "+7 800 555 35 35"
    data.students.add(student)


    val lecturer = lecturerModel(
        position = "доцент"
    )
    lecturer.listDisciplineId.add(1)
    lecturer.id = 1
    lecturer.name = fullName("Мария", "Фаттахова", "Владимировна")
    lecturer.password = "654321"
    lecturer.login = "fattah"
    lecturer.mail = "mvfa@yandex.ru"
    data.lecturers.add(lecturer)

    val group = groupModel(
        id              = 1,
        number          = "4932",
        specialityId    = 1,
        course          = 3
    )
    group.listDisciplineId.add(1)
    group.listDocId.add(1)
    group.listStudentId.add(1)
    group.listTaskId.add(1)
    data.groups.add(group)

    val doc = docModel(
        id = 1,
        disciplineId = 1,
        name = "testDoc",
        description = "test description",
        date = Date(21414L)
    )
    data.docs.add(doc)

    val task = taskModel(
        id = 1,
        name = "vsem pi",
        disciplineId = 1,
        number = 1,
        maxMark = 5,
        description = "adadada",
        deadline = Date(74444L)
    )
    data.tasks.add(task)

    val discipline = disciplineModle(
        id = 1,
        name = "PMO",
        exam = EXAM.EXAM,
        hours = 144
    )
    discipline.lecturerIdList.add(1)
    data.discipline.add(discipline)

    val speciality = specialityModel(
        id = 1,
        code = "09.03.04",
        name = "software engineer",
        educationType = EDUCATION.BACHELOR
    )
    data.speciality.add(speciality)

}