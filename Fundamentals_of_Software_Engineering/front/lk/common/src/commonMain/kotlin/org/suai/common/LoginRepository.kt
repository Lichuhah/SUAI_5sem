package org.suai.common

import mu.KotlinLogging
import okhttp3.*
import okhttp3.MediaType.Companion.toMediaTypeOrNull
import okhttp3.RequestBody.Companion.toRequestBody
import org.suai.common.model.loginModel
import java.io.IOException


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
    fun sendLoginData(data: loginModel): String {
        val client = OkHttpClient()
            .newBuilder()
            .build()
        val mediaType = "application/json".toMediaTypeOrNull()
        val body = """{"login":"${data.login}", "password":"${data.password}"}""".toRequestBody(mediaType)
        val request = Request
            .Builder()
            .url("http://lichuhasite.somee.com/Login/Auth")
            .method("POST", body)
            .addHeader("Content-Type", "application/json")
            .build()

        val responseBody = client.newCall(request).execute().body
        return if ( responseBody != null ) {
            val response = responseBody.string()
            KotlinLogging.logger {}.info { "response=$response" }
            response
        } else {
            "Error response"
        }
    }
}