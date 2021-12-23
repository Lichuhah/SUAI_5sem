package org.suai.common.model

import java.util.*

/**
 * Модель задания
 * @param disciplineId id дисциплины
 * @param name
 * @param number
 * @param maxMark
 * @param description описане
 * @param deadline
 */
data class taskModel(
    override var id:    Int,
    val disciplineId:   Int,
    var name:           String,
    var number:         Int,
    val maxMark:        Int,
    var description:    String,
    var deadline:       Date
) : uuId

// TODO: materialList?
// TODO: mark?

// какой список материалов по заданию ?
// это что то слишком сложное

// не знаю я никаких марков, их вроде растреляли
// а какая оценка у препода ? у декана ?
