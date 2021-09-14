package com.example.lab2;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;

import java.sql.SQLException;
import java.util.List;

@Controller
public class AppointmentController {
    AppointmentDAO appointmentDAO = new AppointmentDAO();

    @GetMapping("appointments")
    public String all(Model model) throws SQLException{
        List<Doctor_Patient> list = appointmentDAO.All();
        model.addAttribute("listApp", list);
        return "AppointmentIndex";
    }

    @GetMapping("appointments/get")
    public String get(Model model) throws SQLException{
        Doctor_Patient doctor_patient = new Doctor_Patient();
        //model.addAttribute("app", doctor_patient);
        List<Doctor> listdoc = new DoctorDAO().All();
        model.addAttribute("listdocs", listdoc);
        List<Patient> listpat = new PatientDAO().All();
        model.addAttribute("listpats", listpat);
        return "AppointmentForm";
    }
    
    @PostMapping(value = "appointments/post")
    public String post(@ModelAttribute Doctor_Patient doctor_patient, Model model) throws SQLException {
        doctor_patient.doc=new DoctorDAO().Get(doctor_patient.iddoc);
        doctor_patient.pat=new PatientDAO().Get(doctor_patient.idpat);
        appointmentDAO.Add(doctor_patient);
        return "redirect:/appointments";
    }

    @GetMapping(value="appointments/delete{id}")
    public String delete(@PathVariable Integer id, Model model) throws SQLException {
        Doctor_Patient doctor_patient = new Doctor_Patient();
        doctor_patient.id=id;
        appointmentDAO.Delete(doctor_patient);
        return "redirect:/appointments";
    }
}

