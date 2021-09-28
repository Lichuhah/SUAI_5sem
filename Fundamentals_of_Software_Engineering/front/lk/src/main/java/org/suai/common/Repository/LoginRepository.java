package org.suai.common.Repository;

import org.suai.common.Response;
import org.suai.common.enum_.REQUEST_TYPE;
import org.suai.common.model.systm.loginModel;
import org.suai.common.net.Net;


public class LoginRepository {

    public static Response findLogin(loginModel data){
        return new Response(Net.INSTANCE.request(REQUEST_TYPE.POST, "Login/Auth", data));
    }
}
