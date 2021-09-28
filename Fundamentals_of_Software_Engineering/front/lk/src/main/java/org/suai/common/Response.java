package org.suai.common;


import org.suai.common.enum_.Role;

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
