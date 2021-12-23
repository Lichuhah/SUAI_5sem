import Model.Costs;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;
import java.io.IOException;
import java.io.PrintWriter;

@WebServlet(name = "tableRemoveDataServlet", value = "/table-remove-data-servlet")
public class TableRemoveDataServlet extends HttpServlet {
    private final Costs costs = Costs.getInstance();

    @Override
    protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
        PrintWriter out = resp.getWriter();
        resp.setContentType("text/html");

        out.write(""
                + "<head>"
                + "    <meta charset=\"UTF-8\">"
                + "    <title>Remove cost</title>"
                + "</head>"
                + "<body>"
                + "    <a href=\"/\">Home page</a>"
                + "    <br>"
                + "    <br>"

                + "<form name=\"RemoveForm\" method=\"post\" action=\"table-remove-data-servlet\">"
                + "    Name: <input type=\"text\" name=\"name\"/> <br/>"
                + "    <input type=\"submit\" value=\"Remove\" />"
                + "</form>"

                + ""
                + "</body>"
        );

        out.close();
    }

    @Override
    protected void doPost(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
        String name = req.getParameter("name");

        try {
            costs.rmItem(name);
        } catch (Exception e) {
            e.printStackTrace();
        }

        resp.sendRedirect("/");
        // getServletContext().getRequestDispatcher("/hello").forward(req, resp);
    }
}

