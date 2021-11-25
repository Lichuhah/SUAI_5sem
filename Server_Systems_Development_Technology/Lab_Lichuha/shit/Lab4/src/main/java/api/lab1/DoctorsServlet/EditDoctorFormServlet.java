package api.lab1.DoctorsServlet;

import api.lab.Models.Doctor;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.annotation.*;
import java.io.IOException;
import java.sql.SQLException;

@WebServlet(name = "EditDoctorFormServlet", value = "/EditDoctorFormServlet")
public class EditDoctorFormServlet extends DoctorServlet {
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        try {
            showEditForm(request,response);
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    private void showEditForm(HttpServletRequest request, HttpServletResponse response) throws SQLException, IOException, ServletException{
        int id = Integer.parseInt(request.getParameter("id"));
        Doctor doc = doctorDAO.Get(id);
        RequestDispatcher dispatcher = request.getRequestDispatcher("/DoctorForm.jsp");
        request.setAttribute("doctor", doc);
        dispatcher.forward(request,response);
    }
}
