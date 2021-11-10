package api.lab1.AppointmentServlet;

import api.lab.Models.Doctor;
import api.lab.Models.Doctor_Patient;
import api.lab.Models.Patient;
import api.lab1.DoctorDAO;
import api.lab1.PatientDAO;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.annotation.*;
import java.io.IOException;
import java.sql.SQLException;
import java.util.List;

@WebServlet(name = "NewAppointmentFormServlet", value = "/NewAppointmentFormServlet")
public class NewAppointmentFormServlet extends AppointmentServlet {
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        try {
            showNewForm(request, response);
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    private void showNewForm(HttpServletRequest request, HttpServletResponse response) throws SQLException, IOException, ServletException{
        RequestDispatcher dispatcher = request.getRequestDispatcher("/AppointmentForm.jsp");
        List<Doctor> listdoc = new DoctorDAO().All();
        request.setAttribute("listdocs", listdoc);
        List<Patient> listpat = new PatientDAO().All();
        request.setAttribute("listpats", listpat);
        dispatcher.forward(request,response);
    }
}
