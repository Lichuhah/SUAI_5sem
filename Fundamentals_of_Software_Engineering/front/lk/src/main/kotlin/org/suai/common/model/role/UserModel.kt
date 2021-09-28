package org.suai.common.model.role

import org.suai.common.model.fullName

/**
 * @param id индификатор пользователя
 * @param name
 * @param login
 * @param password
 * @param mail
 * @param phone телефонный номер (если нет то пустой)
 * **/
open class userModel(
    val id:         Int         = 0,
    var name: fullName = fullName("","", null),
    val login:      String      = "",
    var password:   String      = "",
    var mail:       String?     = null,
    var phone:      String?     = null
)