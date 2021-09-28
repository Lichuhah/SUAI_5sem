package org.suai.common.model.role

/**
 * @param groupId id группы в которой состоит студент
 */
data class studentModel(
    var groupId: Int   = 0
) : userModel()