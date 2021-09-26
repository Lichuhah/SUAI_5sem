package org.suai.common;

public class Response{
    public Role role;
    public String message;

    public Response(Role role, String message) {
        this.role = role;
        this.message = message;
    }
}
