package com.example.lab2;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;

import java.sql.SQLException;
import java.util.List;

@Controller
public class PatientController {
    PatientDAO patientDAO = new PatientDAO();

    @GetMapping("patients")
    public String all(Model model) throws SQLException{
        List<Patient> list = patientDAO.All();
        model.addAttribute("listPatient", list);
        return "PatientIndex";
    }

    @GetMapping(value = "patients/get{id}")
    public String get(@PathVariable Integer id, Model model) throws SQLException {
        Patient patient = patientDAO.Get(id);
        model.addAttribute("patient", patient);
        return "PatientForm";
    }

    @PostMapping(value = "patients/post")
    public String post(@ModelAttribute Patient patient, Model model) throws SQLException {
        patientDAO.Add(patient);
        return "redirect:/patients";
    }

    @PostMapping(value="patients/edit{id}")
    public String edit(@PathVariable Integer id, Patient patient, Model model) throws SQLException {
        patientDAO.Edit(patient);
        return "redirect:/patients";
    }

    @GetMapping(value="patients/delete{id}")
    public String delete(@PathVariable Integer id, Model model) throws SQLException {
        patientDAO.Delete(patientDAO.Get(id));
        return "redirect:/patients";
    }
}

