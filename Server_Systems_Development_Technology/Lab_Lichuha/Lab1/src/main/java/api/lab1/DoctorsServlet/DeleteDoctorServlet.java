package api.lab1.DoctorsServlet;

import api.lab.Models.Doctor;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.annotation.*;
import java.io.IOException;
import java.io.PrintWriter;
import java.sql.SQLException;

@WebServlet(name = "DeleteDoctorServlet", value = "/DeleteDoctorServlet")
public class DeleteDoctorServlet extends DoctorServlet {
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        try {
            deleteDoctor(request, response);
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    private void deleteDoctor(HttpServletRequest request, HttpServletResponse response) throws SQLException, IOException, ServletException{
        Integer id = Integer.valueOf(request.getParameter("id"));

        Doctor doc = new Doctor();
        doc.id=id;
        try {
            doctorDAO.Delete(doc);
            response.sendRedirect("AllDoctorServlet");
        } catch (SQLException ex){
            PrintWriter pw = response.getWriter();
            pw.println("<html><body>");
            pw.println("<h1>" + ex + "</h1>");
            pw.println("</body></html>");
        }


    }
}
