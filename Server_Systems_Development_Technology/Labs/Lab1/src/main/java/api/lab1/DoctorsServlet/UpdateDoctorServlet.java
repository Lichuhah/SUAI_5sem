package api.lab1.DoctorsServlet;

import api.lab.Models.Doctor;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.annotation.*;
import java.io.IOException;
import java.sql.SQLException;

@WebServlet(name = "UpdateDoctorServlet", value = "/UpdateDoctorServlet")
public class UpdateDoctorServlet extends DoctorServlet {
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        try {
            updateDoctor(request, response);
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    private void updateDoctor(HttpServletRequest request, HttpServletResponse response) throws SQLException, IOException, ServletException{
        Integer id = Integer.valueOf(request.getParameter("id"));
        String name = request.getParameter("name");
        Integer cabinet = Integer.valueOf(request.getParameter("cabinet"));
        String speciality = request.getParameter("speciality");

        Doctor doc = new Doctor();
        doc.id=id;
        doc.name=name;
        doc.cabinet=cabinet;
        doc.speciality=speciality;
        //pat.birthday=birthday;
        doctorDAO.Edit(doc);
        response.sendRedirect("AllDoctorServlet");
    }
}
