package org.suai.common;
import com.google.gson.Gson;
import org.suai.common.model.loginModel;
import java.io.IOException;
import java.net.URI;
import java.net.http.HttpClient;
import java.net.http.HttpRequest;
import java.net.http.HttpResponse;

public class LoginRepository {
    public static Response getResponse(loginModel data){
        try {
            return new Response(sendLoginData(data));
        } catch (Exception e) {
            e.printStackTrace();
            return new Response("Throw exception");
        }
    }

    public static String sendLoginData(loginModel data) throws IOException, InterruptedException {
        String uri = "http://www.lichuhasite.somee.com/Student/Login";
        HttpClient client = HttpClient.newBuilder().build();
        Gson gson = new Gson();
        HttpRequest request = HttpRequest.newBuilder()
                .uri(URI.create(uri))
                .POST(HttpRequest.BodyPublishers.ofString(gson.toJson(data)))
                .build();

        HttpResponse<?> response = client.send(request, HttpResponse.BodyHandlers.discarding());
        System.out.println(response.statusCode());

        return response.toString();

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
