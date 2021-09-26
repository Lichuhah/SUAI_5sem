package org.suai.common;

public class LoginManager {

    public Response validate(String login, String password, String secondPassword){
        if(!password.equals(secondPassword)){
            return new Response(Role.NONE, "invalid pass");
        }

        return new Response(Role.NONE, "ok");
    }
}
