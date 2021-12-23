package api.lab1.PatientsServlets;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.annotation.*;
import java.io.IOException;
import java.sql.SQLException;

@WebServlet(name = "NewPatientFormServlet", value = "/NewPatientFormServlet")
public class NewPatientFormServlet extends PatientServlet {
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        try {
            showNewForm(request, response);
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    private void showNewForm(HttpServletRequest request, HttpServletResponse response) throws SQLException, IOException, ServletException{
        RequestDispatcher dispatcher = request.getRequestDispatcher("/PatientForm.jsp");
        dispatcher.forward(request,response);
    }
}
