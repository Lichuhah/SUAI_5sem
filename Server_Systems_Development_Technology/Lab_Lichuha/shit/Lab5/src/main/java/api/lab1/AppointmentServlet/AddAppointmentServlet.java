package api.lab1.AppointmentServlet;

import api.lab.Models.Doctor;
import api.lab.Models.Doctor_Patient;
import api.lab1.AppointmentDAO;
import api.lab1.DoctorDAO;
import api.lab1.PatientDAO;
import jdk.nashorn.internal.runtime.regexp.joni.encoding.IntHolder;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.annotation.*;
import java.io.IOException;
import java.sql.SQLException;

@WebServlet(name = "AddAppointmentServlet", value = "/AddAppointmentServlet")
public class AddAppointmentServlet extends AppointmentServlet {

    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        request.setCharacterEncoding("UTF-8");
        try {
            insertAppointment(request,response);
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    private void insertAppointment(HttpServletRequest request, HttpServletResponse response) throws SQLException, IOException, ServletException{
        Integer id_pat = Integer.valueOf(request.getParameter("id_patient"));
        Integer id_doc = Integer.valueOf(request.getParameter("id_doctor"));
        String info = request.getParameter("info");

        Doctor_Patient doctor_patient = new Doctor_Patient();
        doctor_patient.pat = new PatientDAO().Get(id_pat);
        doctor_patient.doc = new DoctorDAO().Get(id_doc);
        doctor_patient.info = info;
        appointmentDAO.Add(doctor_patient);
        response.sendRedirect("AllAppointmentServlet");
    }
}
