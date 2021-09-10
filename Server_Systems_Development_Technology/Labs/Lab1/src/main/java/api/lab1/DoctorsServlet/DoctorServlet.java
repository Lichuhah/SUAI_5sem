package api.lab1.DoctorsServlet;

import api.lab1.DoctorDAO;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.annotation.*;
import java.io.IOException;

@WebServlet(name = "DoctorServlet", value = "/DoctorServlet")
public class DoctorServlet extends HttpServlet {
    protected DoctorDAO doctorDAO;

    public void init(){
        doctorDAO = new DoctorDAO();
    }
}
