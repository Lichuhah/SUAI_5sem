package api.lab1.AppointmentServlet;

import api.lab1.AppointmentDAO;
import api.lab1.DoctorDAO;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.annotation.*;
import java.io.IOException;

@WebServlet(name = "AppointmentServlet", value = "/AppointmentServlet")
public class AppointmentServlet extends HttpServlet {
    protected AppointmentDAO appointmentDAO;

    public void init(){
        appointmentDAO = new AppointmentDAO();
    }
}
