package org.suai.common.model

import javax.xml.crypto.Data

/**
 * Модель сдачи работы
 * @param id
 * @param taskId
 * @param studentId
 * @param mark итоговая оценка
 * @param passList список попуток сдачи
 */
data class completeTaskModel(
    override val id:    Int,
    val taskId:         Int,
    val studentId:      Int,
    val mark:           Int
) :uuId
{
    val passList = mutableListOf<passTaskModel>()

    /**
     * Внутренний класс описывающий одну попытку сдачи задания
     * @param id id
     * @param description коментарий учащегося
     * @param answer ответ преподавателя
     * @param data дата загрузки
     */
    data class passTaskModel(
        override val id:    Int,
        val description:    String,
        val answer:         String,
        val date:           Data
    ) : uuId
}
