package org.suai.common

import okhttp3.MediaType.Companion.toMediaTypeOrNull
import okhttp3.RequestBody.Companion.toRequestBody
import okhttp3.*
import java.io.IOException
import org.suai.common.model.loginModel
import mu.KotlinLogging
import org.suai.common.net.Net
import org.suai.common.net.REQUEST

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
    fun sendLoginData(data: loginModel) = Net.request(REQUEST.POST, "Login/Auth", """{"login":"${data.login}", "password":"${data.password}"}""")
}