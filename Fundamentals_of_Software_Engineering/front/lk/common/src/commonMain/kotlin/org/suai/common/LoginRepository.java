package org.suai.common;
import org.suai.common.model.loginModel;

import java.io.DataOutputStream;
import java.io.IOException;
import java.net.HttpURLConnection;
import java.net.URL;
import java.nio.charset.StandardCharsets;
import java.util.Arrays;

public class LoginRepository {
    public static Response getResponse(loginModel data){
        try {
            return new Response(sendLoginData(data));
        } catch (IOException e) {
            e.printStackTrace();
            return new Response("Throw exception");
        }
    }

    public static String sendLoginData(loginModel data) throws IOException {
        String request = "http://www.lichuhasite.somee.com/Login/Add";
        String urlParameters = "";

        byte[] postData = urlParameters.getBytes(StandardCharsets.UTF_8);
        URL url = new URL(request);
        HttpURLConnection conn= (HttpURLConnection) url.openConnection();
        conn.setDoOutput(true);
        conn.setInstanceFollowRedirects(false);
        conn.setRequestMethod("POST");
        conn.setRequestProperty("Content-Type", "application/json");
        conn.setRequestProperty("charset", "utf-8");
        conn.setRequestProperty("Content-Length", Integer.toString(postData.length));
        conn.setUseCaches(false);

        try(DataOutputStream wr = new DataOutputStream(conn.getOutputStream())) {
            wr.write(postData);
            return wr.toString();
        }catch (Exception e){
            return "";
        }
    }
}
