package org.suai.common

import okhttp3.MediaType
import okhttp3.OkHttpClient
import okhttp3.Request
import okhttp3.RequestBody
import okhttp3.ResponseBody.Companion.create
import org.suai.common.model.loginModel
import java.io.IOException


object LoginRepository {
    fun getResponse(data: loginModel?): Response {
        return try {
            Response(sendLoginData(data))
        } catch (e: Exception) {
            e.printStackTrace()
            Response("Throw exception")
        }
    }

    @Throws(IOException::class, InterruptedException::class)
    fun sendLoginData(data: loginModel?): String {
        val client = OkHttpClient().newBuilder()
            .build()

        val mediaType = MediaType.parse("text/plain")
        val body = RequestBody.create(mediaType, "{\"login\":\"Student\", \"password\":\"1\"}")
//        val body: RequestBody = RequestBody.Companion. create(mediaType, "{\"login\":\"Student\", \"password\":\"1\"}")
        val request: Request = Request.Builder()
            .url("http://lichuhasite.somee.com/Student/Login")
            .method("POST", body)
            .addHeader("Content-Type", "text/plain")
            .build()
        val response: okhttp3.Response = client.newCall(request).execute()

//        val uri = "http://www.lichuhasite.somee.com/Student/Login"
//        val client = HttpClient.newBuilder().build()
//        val gson = Gson()
//        println(gson.toJson(data))
//        val request = HttpRequest.newBuilder()
//            .uri(URI.create(uri))
//            .setHeader("Content-Type", "application/json")
//            .POST(HttpRequest.BodyPublishers.ofString(gson.toJson(data)))
//            .build()
//        val response: HttpResponse<*> = client.send(request, HttpResponse.BodyHandlers.discarding())
//        KotlinLogging.logger {}.info { "response.headers()= ${response.headers()}" }
//        KotlinLogging.logger {}.info { "response.body()= ${response.body()}" }
//        KotlinLogging.logger {}.info { "response.previousResponse()= ${response.previousResponse()}" }
//        KotlinLogging.logger {}.info { "response.uri()= ${response.uri()}" }
//        KotlinLogging.logger {}.info { "response.statusCode()= ${response.statusCode()}" }
//        return response.toString()

//        String       postUrl       = "http://www.lichuhasite.somee.com/Login/Add";
//        Gson gson          = new Gson();
//        HttpClient httpClient    = HttpClientBuilder.create().build();
//        HttpPost     post          = new HttpPost(postUrl);
//        StringEntity postingString = new StringEntity(gson.toJson(pojo1));//gson.tojson() converts your pojo to json
//        post.setEntity(postingString);
//        post.setHeader("Content-type", "application/json");
//        HttpResponse response = httpClient.execute(post);
    }
}