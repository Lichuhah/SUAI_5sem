package org.suai.common.model.role

import org.suai.common.model.fullName
import org.suai.common.model.specialityModel

/**
 * @param groupId id группы в которой состоит студент
 * @param specialityId id специальности
 */
class studentModel(
    val groupId:        Int
) : userModel()

// TODO: markList?