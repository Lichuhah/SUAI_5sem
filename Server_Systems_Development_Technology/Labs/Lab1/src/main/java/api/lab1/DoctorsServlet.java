package api.lab1;

import api.lab.Models.Doctor;
import api.lab.Models.Patient;

import javax.print.Doc;
import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.annotation.*;
import java.io.IOException;
import java.sql.SQLException;
import java.util.List;

@WebServlet(name = "DoctorsServlet", value = "/DoctorsServlet")
public class DoctorsServlet extends HttpServlet {
    private DoctorDAO doctorDAO;

    public void init(){
        doctorDAO = new DoctorDAO();
    }

    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        String action = request.getServletPath();
        try {
            switch (action) {
                case "/DoctorsServlet/add":
                    showNewForm(request, response);
                    break;
                case "/DoctorsServlet/insert":
                    insertDoctor(request, response);
                    break;
                case "/DoctorsServlet/delete":
                    deleteDoctor(request, response);
                    break;
                case "/DoctorsServlet/edit":
                    showEditForm(request, response);
                    break;
                case "/DoctorsServlet/update":
                    updateDoctor(request, response);
                    break;
                default:
                    listDoctor(request, response);
                    break;
            }
        } catch (SQLException ex) {
            throw new ServletException(ex);
        }
    }

    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        response.setContentType("text/html; charset=UTF-8");
        response.setCharacterEncoding("UTF-8");
        doGet(request, response);
    }

    private void listDoctor(HttpServletRequest request, HttpServletResponse response) throws SQLException, IOException, ServletException{
        List<Doctor> list = doctorDAO.All();
        request.setAttribute("listDoctor", list);
        RequestDispatcher dispatcher = request.getRequestDispatcher("/DoctorIndex.jsp");
        dispatcher.forward(request,response);
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
        response.sendRedirect("all");
    }
    private void showEditForm(HttpServletRequest request, HttpServletResponse response) throws SQLException, IOException, ServletException{
        int id = Integer.parseInt(request.getParameter("id"));
        Doctor doc = doctorDAO.Get(id);
        RequestDispatcher dispatcher = request.getRequestDispatcher("/DoctorForm.jsp");
        request.setAttribute("doctor", doc);
        dispatcher.forward(request,response);
    }
    private void deleteDoctor(HttpServletRequest request, HttpServletResponse response) throws SQLException, IOException, ServletException{
        Integer id = Integer.valueOf(request.getParameter("id"));

        Doctor doc = new Doctor();
        doc.id=id;
        doctorDAO.Delete(doc);
        response.sendRedirect("all");

    }
    private void insertDoctor(HttpServletRequest request, HttpServletResponse response) throws SQLException, IOException, ServletException{
        String name = request.getParameter("name");
        Integer cabinet = Integer.valueOf(request.getParameter("cabinet"));
        String speciality = request.getParameter("speciality");

        Doctor doc = new Doctor();
        doc.name=name;
        doc.cabinet=cabinet;
        doc.speciality=speciality;
        doctorDAO.Add(doc);
        response.sendRedirect("all");

    }
    private void showNewForm(HttpServletRequest request, HttpServletResponse response) throws SQLException, IOException, ServletException{
        RequestDispatcher dispatcher = request.getRequestDispatcher("/DoctorForm.jsp");
        dispatcher.forward(request,response);
    }
}
