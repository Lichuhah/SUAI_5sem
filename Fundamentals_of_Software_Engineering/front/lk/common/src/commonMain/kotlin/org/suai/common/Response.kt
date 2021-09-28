package org.suai.common

class Response {
    var role: Role
    var message: String

    constructor(message: String) {
        role = Role.NONE
        this.message = message
    }

    constructor(role: Role, message: String) {
        this.role = role
        this.message = message
    }
}