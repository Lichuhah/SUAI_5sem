package api.lab1.DoctorsServlet;

import api.lab.Models.Doctor;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.annotation.*;
import java.io.IOException;
import java.sql.SQLException;
import java.util.List;

@WebServlet(name = "AllDoctorServlet", value = "/AllDoctorServlet")
public class AllDoctorServlet extends DoctorServlet {
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        try {
            listDoctor(request, response);
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    private void listDoctor(HttpServletRequest request, HttpServletResponse response) throws SQLException, IOException, ServletException{
        List<Doctor> list = doctorDAO.All();
        request.setAttribute("listDoctor", list);
        RequestDispatcher dispatcher = request.getRequestDispatcher("/DoctorIndex.jsp");
        dispatcher.forward(request,response);
    }
}
