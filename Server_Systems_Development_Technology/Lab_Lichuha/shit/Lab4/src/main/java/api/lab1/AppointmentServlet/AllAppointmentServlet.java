package api.lab1.AppointmentServlet;

import api.lab.Models.Doctor;
import api.lab.Models.Doctor_Patient;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.annotation.*;
import java.io.IOException;
import java.sql.SQLException;
import java.util.List;

@WebServlet(name = "AllAppointmentServlet", value = "/AllAppointmentServlet")
public class AllAppointmentServlet extends AppointmentServlet {
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        try {
            listAppoint(request, response);
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    private void listAppoint(HttpServletRequest request, HttpServletResponse response) throws SQLException, IOException, ServletException{
        List<Doctor_Patient> list = appointmentDAO.All();
        request.setAttribute("listApp", list);
        RequestDispatcher dispatcher = request.getRequestDispatcher("/AppointmentIndex.jsp");
        dispatcher.forward(request,response);
    }

}
