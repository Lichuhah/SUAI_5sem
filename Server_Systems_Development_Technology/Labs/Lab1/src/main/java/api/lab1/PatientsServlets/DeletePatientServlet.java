package api.lab1.PatientsServlets;

import api.lab.Models.Patient;
import api.lab1.PatientDAO;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.annotation.*;
import java.io.IOException;
import java.sql.SQLException;

@WebServlet(name = "DeletePatientServlet", value = "/DeletePatientServlet")
public class DeletePatientServlet extends PatientServlet {
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        try {
            deletePatient(request, response);
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    private void deletePatient(HttpServletRequest request, HttpServletResponse response) throws SQLException, IOException, ServletException{
        Integer id = Integer.valueOf(request.getParameter("id"));

        Patient pat = new Patient();
        pat.id=id;
        patientDAO.Delete(pat);
        response.sendRedirect("AllPatientServlet");

    }
}
