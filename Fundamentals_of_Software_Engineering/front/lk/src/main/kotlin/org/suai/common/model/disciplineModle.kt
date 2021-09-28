package org.suai.common.model

import org.suai.common.enum_.EXAM
import org.suai.common.model.role.lecturerModel

data class disciplineModle(
    override val id:             Int                         = 0,
    val name:           String                      = "",
    val lecturerList:   MutableList<lecturerModel>  = mutableListOf(),
    val exam:           EXAM                        = EXAM.NONE,
    val hours:          Int                         = 0
) : uuId