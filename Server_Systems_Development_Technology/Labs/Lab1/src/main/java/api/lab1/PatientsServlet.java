package api.lab1;

import api.lab.Models.Patient;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.annotation.*;
import java.io.IOException;
import java.sql.SQLException;
import java.sql.Time;
import java.time.Instant;
import java.util.Date;
import java.util.List;

@WebServlet(name = "PatientsServlet", value = "/PatientsServlet")
public class PatientsServlet extends HttpServlet {
    private PatientDAO patientDAO;

    public void init(){
        patientDAO = new PatientDAO();
    }

    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        String action = request.getServletPath();
        //action = request.getParameter("action");
        try {
            switch (action) {
                case "/PatientsServlet/add":
                    showNewForm(request, response);
                    break;
                case "/PatientsServlet/insert":
                    insertPatient(request, response);
                    break;
                case "/PatientsServlet/delete":
                    deletePatient(request, response);
                    break;
                case "/PatientsServlet/edit":
                    showEditForm(request, response);
                    break;
                case "/PatientsServlet/update":
                    updatePatient(request, response);
                    break;
                default:
                    listPatient(request, response);
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

    private void listPatient(HttpServletRequest request, HttpServletResponse response) throws SQLException, IOException, ServletException{
        List<Patient> list = patientDAO.All();
        request.setAttribute("listPatient", list);
        RequestDispatcher dispatcher = request.getRequestDispatcher("/PatientIndex.jsp");
        dispatcher.forward(request,response);
    }
    private void updatePatient(HttpServletRequest request, HttpServletResponse response) throws SQLException, IOException, ServletException{
        Integer id = Integer.valueOf(request.getParameter("id"));
        String name = request.getParameter("name");
        //Date birthday = Date.from(Instant.parse(request.getParameter("birthday")));

        Patient pat = new Patient();
        pat.id=id;
        pat.name=name;
        //pat.birthday=birthday;
        patientDAO.Edit(pat);
        response.sendRedirect("all");
    }
    private void showEditForm(HttpServletRequest request, HttpServletResponse response) throws SQLException, IOException, ServletException{
        int id = Integer.parseInt(request.getParameter("id"));
        Patient pat = patientDAO.Get(id);
        RequestDispatcher dispatcher = request.getRequestDispatcher("/PatientForm.jsp");
        request.setAttribute("patient", pat);
        dispatcher.forward(request,response);
    }
    private void deletePatient(HttpServletRequest request, HttpServletResponse response) throws SQLException, IOException, ServletException{
        Integer id = Integer.valueOf(request.getParameter("id"));

        Patient pat = new Patient();
        pat.id=id;
        patientDAO.Delete(pat);
        response.sendRedirect("all");

    }
    private void insertPatient(HttpServletRequest request, HttpServletResponse response) throws SQLException, IOException, ServletException{
        String name = request.getParameter("name");
        //Date birthday = new Date(request.getParameter("birthday"));

        Patient pat = new Patient();
        pat.name=name;
        //pat.birthday=birthday;
        patientDAO.Add(pat);
        response.sendRedirect("all");

    }
    private void showNewForm(HttpServletRequest request, HttpServletResponse response) throws SQLException, IOException, ServletException{
        RequestDispatcher dispatcher = request.getRequestDispatcher("/PatientForm.jsp");
        dispatcher.forward(request,response);
    }
}
