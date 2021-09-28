package org.suai.common

import java.io.IOException
import org.suai.common.model.systm.loginModel
import org.suai.common.net.Net
import org.suai.common.enum_.REQUEST_TYPE

object LoginRepository {
    fun getResponse(data: loginModel): Response {
        return try {
            Response(sendLoginData(data))
        } catch (e: Exception) {
            e.printStackTrace()
            Response("Throw exception")
        }
    }

    @Throws(IOException::class, InterruptedException::class)
    fun sendLoginData(data: loginModel) = Net.request(REQUEST_TYPE.POST, "Login/Auth", """{"login":"${data.login}", "password":"${data.password}"}""")
}