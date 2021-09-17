import Model.Costs;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.io.PrintWriter;

@WebServlet(name = "homePageServlet", value = "/")
public class HomePageServlet extends HttpServlet {
    private final Costs costs = Costs.getInstance();

    @Override
    protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
        resp.setContentType("text/html");

        PrintWriter out = resp.getWriter();

        out.write(""
            + "<html><body>"
            +   "<label>Family budget</label>"
            +   "<br>"
            +   "<a href=\"table-view-servlet\">Open table</a>"
            +   "<br>"
            +   "<a href=\"table-add-data-servlet\">Add data to table</a>"
            +   "<br>"
            +   "<a href=\"table-remove-data-servlet\">Remove data to table</a>"
            +   ""
            + "</body></html>"
        );
        out.close();

        resp.setStatus(200);
    }
}
