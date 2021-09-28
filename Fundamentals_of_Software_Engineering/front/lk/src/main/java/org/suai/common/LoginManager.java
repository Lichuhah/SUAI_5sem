package org.suai.common;
import org.suai.common.Response;
import org.suai.common.model.systm.loginModel;

import static org.suai.common.LoginRepositoryKt.getServerResponse;

public class LoginManager {

    /**
     * Проверяет данные на клиенте, затем передает их на сервер и возвращает
     * от него ответ
     * @param loginModel - Данные (логин и пароль)
     * @return Response - Ответ о правильности данных либо статус операции
     */
    public static Response sendToServer(loginModel loginModel){
        return validate(loginModel);
    }

    private static Response validate(loginModel data){
        if (data.getLogin().equals("")) {
            return new Response("Login is empty");
        }

        return sendToRepository(data);
    }

    private static Response sendToRepository(loginModel data){
        return getServerResponse(data);
    }
}
