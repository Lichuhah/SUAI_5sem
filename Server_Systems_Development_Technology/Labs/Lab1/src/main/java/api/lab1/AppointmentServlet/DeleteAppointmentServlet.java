package api.lab1.AppointmentServlet;

import api.lab.Models.Doctor;
import api.lab.Models.Doctor_Patient;
import api.lab1.DoctorDAO;
import api.lab1.PatientDAO;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.annotation.*;
import java.io.IOException;
import java.sql.SQLException;

@WebServlet(name = "DeleteAppointmentServlet", value = "/DeleteAppointmentServlet")
public class DeleteAppointmentServlet extends AppointmentServlet {
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        try {
            deleteAppointment(request, response);
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    private void deleteAppointment(HttpServletRequest request, HttpServletResponse response) throws SQLException, IOException, ServletException{
        Integer id_Patient = Integer.valueOf(request.getParameter("id_patient"));
        Integer id_Doctor = Integer.valueOf(request.getParameter("id_doctor"));
        Doctor_Patient doctor_patient = new Doctor_Patient();
        doctor_patient.pat = new PatientDAO().Get(id_Patient);
        doctor_patient.doc = new DoctorDAO().Get(id_Doctor);
        appointmentDAO.Delete(doctor_patient);
        response.sendRedirect("AllAppointmentServlet");
    }
}
