import Model.Costs;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;
import java.io.IOException;
import java.io.PrintWriter;

@WebServlet(name = "tableAddDataServlet", value = "/table-add-data-servlet")
public class TableAddDataServlet extends HttpServlet {
    private final Costs costs = Costs.getInstance();

    @Override
    protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
        PrintWriter out = resp.getWriter();
        resp.setContentType("text/html");

        out.write(""
                + "<head>"
                + "    <meta charset=\"UTF-8\">"
                + "    <title>Add cost</title>"
                + "</head>"
                + "<body>"
                + "    <a href=\"/\">Home page</a>"
                + "    <br>"
                + "    <br>"

                + "<form name=\"AddForm\" method=\"post\" action=\"table-add-data-servlet\">"
                + "    Name: <input type=\"text\" name=\"name\"/> <br/>"
                + "    Price: <input type=\"text\" name=\"price\"/> <br/>"
                + "    <input type=\"submit\" value=\"Add\" />"
                + "</form>"

                + ""
                + "</body>"
        );

        out.close();
    }

    @Override
    protected void doPost(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
        String name = req.getParameter("name");
        String price = req.getParameter("price");

        try {
            costs.addItem(name, Integer.parseInt(price));
        } catch (Exception e) {
            e.printStackTrace();
        }

        resp.sendRedirect("/");
        // getServletContext().getRequestDispatcher("/hello").forward(req, resp);
    }
}

