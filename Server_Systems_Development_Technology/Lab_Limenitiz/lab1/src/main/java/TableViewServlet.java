import Model.Costs;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;
import java.io.IOException;
import java.io.PrintWriter;

@WebServlet(name = "tableViewServlet", value = "/table-view-servlet")
public class TableViewServlet extends HttpServlet {
    private final Costs costs = Costs.getInstance();

    @Override
    protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
        PrintWriter out = resp.getWriter();

        String username = req.getParameter("username");

        resp.setContentType("text/html");

        out.write(""
            + "<head>"
            + "    <meta charset=\"UTF-8\">"
            + "    <title>Budget costs</title>"
            + "</head>"
            + "<body>"

            + "    <a href=\"/\">Home page</a>"
            + "    <br>"
            + "    <br>"
            + "    <table border=\"1\">"
            + "        <caption> Cost items </caption>"
            + ""
            + "        <tr>"
            + "            <th>Name</th>"
            + "            <th>Price</th>"
            + "        </tr>"
        );

        for (int i = 0; i < costs.getNames().size(); i++) {
            out.write(""
                    + "        <tr>"
                    + "            <th>"+ costs.getNames().get(i) +"</th>"
                    + "            <th>"+ costs.getPrices().get(i) +"</th>"
                    + "        </tr>"
                    +""
            );
        }

        out.write(""
            + ""
            + "    </table>"
            + ""
            + "</body>"
        );

        out.close();
    }
}

