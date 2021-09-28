package org.suai.common.Repository;

import org.suai.common.Response;
import org.suai.common.enum_.REQUEST;
import org.suai.common.model.systm.loginModel;
import org.suai.common.net.Net;


public class LoginRepository {

    public static Response findLogin(loginModel data){
        return new Response(Net.INSTANCE.request(REQUEST.POST, "Login/Auth", data));
    }
}
