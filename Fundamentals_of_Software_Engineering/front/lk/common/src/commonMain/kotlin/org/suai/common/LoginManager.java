package org.suai.common;
import org.suai.common.model.loginModel;


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
        // if(1){}
        // if(1){}

        return sendToRepository(data);
    }

    private static Response sendToRepository(loginModel data){
        return LoginRepository.getResponse(data);
    }
}
