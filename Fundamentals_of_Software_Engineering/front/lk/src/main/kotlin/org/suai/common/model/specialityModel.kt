package org.suai.common.model

import org.suai.common.enum_.EDUCATION

/**
 * @param Id id специальности
 * @param Name название специальности
 * @param Code код специальности
 * @param educationType тип программы обучения
**/
data class specialityModel(
    val id:            Int,
    val code:          String,
    val name:          String,
    val educationType: EDUCATION,
)