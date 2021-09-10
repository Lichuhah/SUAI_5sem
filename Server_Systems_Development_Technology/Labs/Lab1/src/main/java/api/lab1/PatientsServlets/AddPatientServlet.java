package api.lab1.PatientsServlets;

import api.lab.Models.Patient;
import api.lab1.PatientDAO;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.annotation.*;
import java.io.IOException;
import java.sql.SQLException;

@WebServlet(name = "AddPatientServlet", value = "/AddPatientServlet")
public class AddPatientServlet extends PatientServlet {
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        try {
            insertPatient(request, response);
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    private void insertPatient(HttpServletRequest request, HttpServletResponse response) throws SQLException, IOException, ServletException{
        String name = request.getParameter("name");
        //Date birthday = new Date(request.getParameter("birthday"));

        Patient pat = new Patient();
        pat.name=name;
        //pat.birthday=birthday;
        patientDAO.Add(pat);
        response.sendRedirect("AllPatientServlet");

    }
}
