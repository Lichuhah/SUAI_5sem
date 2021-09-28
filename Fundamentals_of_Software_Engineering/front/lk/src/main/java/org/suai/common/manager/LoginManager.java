package org.suai.common.manager;
import org.suai.common.Repository.LoginRepository;
import org.suai.common.Response;
import org.suai.common.model.systm.loginModel;


public class LoginManager {

    /**
     * Проверяет данные на клиенте, затем передает их на сервер и возвращает
     * от него ответ
     * @param data - Данные (логин и пароль)
     * @return Response - Ответ о правильности данных либо статус операции
     */
    public static Response findLogin(loginModel data){
        return validate(data);
    }

    private static Response validate(loginModel data){
        if (data.getLogin().equals("")) {
            return new Response("Login is empty");
        }

        return LoginRepository.findLogin(data);
    }
}
