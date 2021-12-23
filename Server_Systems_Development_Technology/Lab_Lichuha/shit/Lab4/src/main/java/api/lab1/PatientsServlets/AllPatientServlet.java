package api.lab1.PatientsServlets;

import api.lab.Models.Patient;
import api.lab1.PatientDAO;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.annotation.*;
import java.io.IOException;
import java.sql.SQLException;
import java.util.List;

@WebServlet(name = "AllPatientServlet", value = "/AllPatientServlet")
public class AllPatientServlet extends PatientServlet {
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        try {
            listPatient(request, response);
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    private void listPatient(HttpServletRequest request, HttpServletResponse response) throws SQLException, IOException, ServletException{
        List<Patient> list = patientDAO.All();
        request.setAttribute("listPatient", list);
        RequestDispatcher dispatcher = request.getRequestDispatcher("/PatientIndex.jsp");
        dispatcher.forward(request,response);
    }
}
