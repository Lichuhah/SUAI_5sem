package com.example.lab2;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;

import java.sql.SQLException;
import java.util.List;

@Controller
public class PatientController {
    @GetMapping("patient")
    public String all(Model model) throws SQLException {
        List<api.lab.Models.Patient> list = new api.lab1.PatientDAO().All();
        model.addAttribute("listPatient", list);
        return "PatientIndex";
    }
}
