package org.suai.common.model

import java.sql.Time

data class taskModel(
    override var id:             Int,
    var name:           String,
    var number:         Int,
    var description:    String,
    var deadline:       Time
) : uuId