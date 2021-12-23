import Model.Costs;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.io.PrintWriter;
import java.nio.charset.StandardCharsets;
import java.nio.file.Files;
import java.nio.file.Path;

@WebServlet(name = "homePageServlet", value = "/")
public class HomePageServlet extends HttpServlet {
    private final Costs costs = Costs.getInstance();

    @Override
    protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
        resp.setContentType("text/html");

        PrintWriter out = resp.getWriter();

        Path path = Path.of("D:\\Programming\\Projects\\SUAI\\" +
                "Server_Systems_Development_Technology\\Lab_Limenitiz\\lab1\\src\\main\\resources\\" +
                "home-page.html");
        String html =  Files.readString(path, StandardCharsets.UTF_8);

        out.write(html);
        out.close();

        resp.setStatus(200);
    }
}
