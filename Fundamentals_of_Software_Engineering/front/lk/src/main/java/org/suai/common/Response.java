package org.suai.common;

public class Response {
    public Role role;
    public String message;

    public Response(String message) {
            role = Role.NONE;
            this.message = message;
    }

    public Response(Role role, String message) {
            this.role = role;
            this.message = message;
    }
}
