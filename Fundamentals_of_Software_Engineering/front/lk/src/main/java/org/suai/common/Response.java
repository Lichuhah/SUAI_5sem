package org.suai.common;

public class Response {
    Role role;
    String message;

    Response(String message) {
            role = Role.NONE;
            this.message = message;
    }

    Response(Role role, String message) {
            this.role = role;
            this.message = message;
    }
}
