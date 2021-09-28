package org.suai.common.model

import java.sql.Time

data class taskModel(
    var id:             Int,
    var name:           String,
    var number:         Int,
    var description:    String,
    var deadline:       Time
)