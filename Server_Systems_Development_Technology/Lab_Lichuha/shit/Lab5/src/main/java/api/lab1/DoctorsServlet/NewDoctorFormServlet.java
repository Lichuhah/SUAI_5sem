package api.lab1.DoctorsServlet;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.annotation.*;
import java.io.IOException;
import java.sql.SQLException;

@WebServlet(name = "NewDoctorFormServlet", value = "/NewDoctorFormServlet")
public class NewDoctorFormServlet extends DoctorServlet {
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        try {
            showNewForm(request, response);
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    private void showNewForm(HttpServletRequest request, HttpServletResponse response) throws SQLException, IOException, ServletException{
        RequestDispatcher dispatcher = request.getRequestDispatcher("/DoctorForm.jsp");
        dispatcher.forward(request,response);
    }
}
