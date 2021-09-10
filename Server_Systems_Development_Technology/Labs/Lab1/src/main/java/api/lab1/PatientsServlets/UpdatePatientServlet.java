package api.lab1.PatientsServlets;

import api.lab.Models.Patient;
import api.lab1.PatientDAO;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.annotation.*;
import java.io.IOException;
import java.sql.SQLException;

@WebServlet(name = "UpdatePatientServlet", value = "/UpdatePatientServlet")
public class UpdatePatientServlet extends PatientServlet {
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        try {
            updatePatient(request,response);
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    private void updatePatient(HttpServletRequest request, HttpServletResponse response) throws SQLException, IOException, ServletException {
        Integer id = Integer.valueOf(request.getParameter("id"));
        String name = request.getParameter("name");
        //Date birthday = Date.from(Instant.parse(request.getParameter("birthday")));

        Patient pat = new Patient();
        pat.id = id;
        pat.name = name;
        //pat.birthday=birthday;
        patientDAO.Edit(pat);
        response.sendRedirect("all");
    }
}
