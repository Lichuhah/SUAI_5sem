package org.suai.common.model

import java.sql.Time

data class taskModel(
    override var id:    Int,
    var name:           String,
    var number:         Int,
    var description:    String,
    var deadline:       Time // TODO: DateTime?
) : uuId

// TODO: materialList?
// TODO: mark?

// какой список материалов по заданию ?
// это что то слишком сложное

// не знаю я никаких марков, их вроде растреляли
// а какая оценка у препода ? у декана ?
