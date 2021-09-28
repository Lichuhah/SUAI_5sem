package org.suai.common.net

import com.google.gson.GsonBuilder
import mu.KotlinLogging
import okhttp3.MediaType.Companion.toMediaTypeOrNull
import okhttp3.OkHttpClient
import okhttp3.Request
import okhttp3.RequestBody.Companion.toRequestBody
import org.suai.common.enum_.REQUEST_TYPE

object Net {
    private val client      = OkHttpClient().newBuilder().build()
    private val mediaType   = "application/json".toMediaTypeOrNull()
    private val gsonBuilder = GsonBuilder().create()

    private inline fun method(request: REQUEST_TYPE) =
    when( request ) {
        REQUEST_TYPE.POST    -> "POST"
        REQUEST_TYPE.PUT     -> "PUT"
        REQUEST_TYPE.GET     -> "GET"
        REQUEST_TYPE.DELETE  -> "DELETE"
    }

    /** выполнение зароса
     * @param request тип запроса
     * @param urn часть после uri(http://lichuhasite.somee.com/)
     * @param content строка json с данными отправляемыми на сервер
     * @return строка с json объектом
     * **/
    fun request(request: REQUEST_TYPE, urn: String, content: Any): String {
        val stringRequestBody : String =
            if ( content is String ) content
            else gsonBuilder.toJson(content)
        val responseBody = client.newCall(
            Request
                .Builder()
                .url("http://lichuhasite.somee.com/$urn")
                .method( method(request), stringRequestBody.toRequestBody(mediaType))
                .addHeader("Content-Type", "application/json")
                .build()
        ).execute()
         .body
        return if (responseBody != null) {
            val response = responseBody.string()
            KotlinLogging.logger {}.info { "response=$response" }
            response
        } else {
            "Error response"
        }
    }

}