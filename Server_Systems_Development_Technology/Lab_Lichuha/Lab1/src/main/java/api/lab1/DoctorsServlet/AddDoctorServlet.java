package api.lab1.DoctorsServlet;

import api.lab.Models.Doctor;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.annotation.*;
import java.io.IOException;
import java.sql.SQLException;

@WebServlet(name = "AddDoctorServlet", value = "/AddDoctorServlet")
public class AddDoctorServlet extends DoctorServlet {
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        request.setCharacterEncoding("UTF-8");
        try {
            insertDoctor(request,response);
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    private void insertDoctor(HttpServletRequest request, HttpServletResponse response) throws SQLException, IOException, ServletException{
        String name = request.getParameter("name");
        Integer cabinet = Integer.valueOf(request.getParameter("cabinet"));
        String speciality = request.getParameter("speciality");
        String surname = request.getParameter("surname");
        String midname = request.getParameter("midname");

        Doctor doc = new Doctor();
        doc.name=name;
        doc.cabinet=cabinet;
        doc.speciality=speciality;
        doc.surname=surname;
        doc.midname=midname;
        doctorDAO.Add(doc);
        response.sendRedirect("AllDoctorServlet");
    }
}
