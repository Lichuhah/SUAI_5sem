package org.suai.common;

import org.suai.common.model.loginModel;
import org.suai.common.model.userModel;

import java.io.DataOutputStream;
import java.io.IOException;
import java.net.HttpURLConnection;
import java.net.URL;
import java.nio.charset.StandardCharsets;

public class LoginRepository {
    public static Response getResponse(loginModel data){
        return new Response(Role.NONE, "err");
    }

    public String sendLoginData(userModel user) throws IOException {
        String urlParameters = "param1=a&param2=b&param3=c";
        byte[] postData = urlParameters.getBytes( StandardCharsets.UTF_8 );
        int postDataLength = postData.length;
        String request = "http://example.com/index.php";
        URL url = new URL( request );
        HttpURLConnection conn= (HttpURLConnection) url.openConnection();
        conn.setDoOutput( true );
        conn.setInstanceFollowRedirects( false );
        conn.setRequestMethod( "POST" );
        conn.setRequestProperty( "Content-Type", "application/json");
        conn.setRequestProperty( "charset", "utf-8");
        conn.setRequestProperty( "Content-Length", Integer.toString( postDataLength ));
        conn.setUseCaches( false );

        try( DataOutputStream wr = new DataOutputStream( conn.getOutputStream())) {
            wr.write( postData );
        }

        return "";
    }
}
