package org.suai.common.model.role

import org.suai.common.model.userModel

/**
 * @param groupId id группы в которой состоит студент
 */
data class studentModel(
    var groupId: Int,
) : userModel()