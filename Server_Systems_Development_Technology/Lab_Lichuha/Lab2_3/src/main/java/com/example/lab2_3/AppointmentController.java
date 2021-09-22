package com.example.lab2_3;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;

import javax.print.Doc;
import java.sql.SQLException;
import java.util.List;

@RestController
public class AppointmentController {
    AppointmentDAO appointmentDAO = new AppointmentDAO();

    @GetMapping("appointments/all")
    public List<Doctor_Patient> all() throws SQLException{
        List<Doctor_Patient> list = appointmentDAO.All();
        return list;
    }

    @PostMapping(value = "appointments/post")
    public void post(@RequestBody Doctor_Patient doctor_patient) throws SQLException {
        doctor_patient.doc=new DoctorDAO().Get(doctor_patient.iddoc);
        doctor_patient.pat=new PatientDAO().Get(doctor_patient.idpat);
        appointmentDAO.Add(doctor_patient);
    }

    @DeleteMapping(value="appointments/delete{id}")
    public void delete(@PathVariable Integer id) throws SQLException {
        Doctor_Patient doctor_patient = new Doctor_Patient();
        doctor_patient.id=id;
        appointmentDAO.Delete(doctor_patient);
    }
}

