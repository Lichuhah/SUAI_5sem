package org.suai.common

//import org.suai.common.model.loginModel.login
import org.suai.common.model.loginModel
import org.suai.common.LoginRepository

class LoginManager {
    /**
     * Проверяет данные на клиенте, затем передает их на сервер и возвращает
     * от него ответ
     * @param loginModel Данные (логин и пароль)
     * @return Response Ответ о правильности данных либо статус операции
     */
    fun sendToServer(loginModel: loginModel): Response {
        return validate(loginModel)
    }

    private fun validate(data: loginModel): Response {
        return if (data.login == "") {
            Response("Login is empty")
        } else sendToRepository(data)
    }

    private fun sendToRepository(data: loginModel): Response {
        return LoginRepository.getResponse(data)
    }
}