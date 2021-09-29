package org.suai.common.model.role

import org.suai.common.model.fullName
import org.suai.common.model.uuId

/**
 * @param id индификатор пользователя
 * @param name
 * @param login
 * @param password
 * @param mail
 * @param phone телефонный номер (если нет то пустой)
 * **/
open class userModel(
    override var id:    Int         = -1,
    var name:           fullName?   = null,
    var login:          String?     = null,
    var password:       String?     = null,
    var mail:           String?     = null,
    var phone:          String?     = null
): uuId