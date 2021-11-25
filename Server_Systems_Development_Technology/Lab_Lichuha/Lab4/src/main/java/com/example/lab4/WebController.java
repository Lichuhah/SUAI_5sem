package com.example.lab4;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;

@Controller
public class WebController {
    @GetMapping("/")
    public String MainPage() {
        return "MainMenu";
    }

    @GetMapping("doctors")
    public String DocIndex() {
        return "DoctorIndex";
    }

    @GetMapping("doctors/view{id}")
    public String DocGet(@PathVariable int id, Model model){
        model.addAttribute("docId", id);
        return "DoctorForm";
    }

    @GetMapping("patients")
    public String PatIndex() {
        return "PatientIndex";
    }

    @GetMapping("patients/view{id}")
    public String PatGet(@PathVariable int id, Model model){
        model.addAttribute("patId", id);
        return "PatientForm";
    }

    @GetMapping("appointments")
    public String AppIndex() {
        return "AppointmentsIndex";
    }

    @GetMapping("appointments/view")
    public String AppGet(){
        return "AppointmentForm";
    }
}
