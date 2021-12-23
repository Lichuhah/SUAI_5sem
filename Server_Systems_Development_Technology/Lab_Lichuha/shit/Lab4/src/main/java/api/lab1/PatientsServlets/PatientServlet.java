package api.lab1.PatientsServlets;

import api.lab1.PatientDAO;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.annotation.*;
import java.io.IOException;

@WebServlet(name = "PatientServlet", value = "/PatientServlet")
public class PatientServlet extends HttpServlet {
    protected PatientDAO patientDAO;

    public void init() {
        patientDAO = new PatientDAO();
    }
}
