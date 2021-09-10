package api.lab1.PatientsServlets;

import api.lab.Models.Patient;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.annotation.*;
import java.io.IOException;
import java.sql.SQLException;

@WebServlet(name = "EditPatientFormServlet", value = "/EditPatientFormServlet")
public class EditPatientFormServlet extends PatientServlet {
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        try {
            showEditForm(request, response);
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    private void showEditForm(HttpServletRequest request, HttpServletResponse response) throws SQLException, IOException, ServletException{
        int id = Integer.parseInt(request.getParameter("id"));
        Patient pat = patientDAO.Get(id);
        RequestDispatcher dispatcher = request.getRequestDispatcher("/PatientForm.jsp");
        request.setAttribute("patient", pat);
        dispatcher.forward(request,response);
    }
}
