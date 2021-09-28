package org.suai.common.model

import org.suai.common.enum_.EDUCATION_TYPE

/**
 * @param Id id специальности
 * @param Name название специальности
 * @param Code код специальности
 * @param educationType тип программы обучения
**/
data class specialityModel(
    val Id:   Int                       = 0,
    val Code: String                    = "",
    val Name: String                    = "",
    val educationType: EDUCATION_TYPE = EDUCATION_TYPE.NONE,
)