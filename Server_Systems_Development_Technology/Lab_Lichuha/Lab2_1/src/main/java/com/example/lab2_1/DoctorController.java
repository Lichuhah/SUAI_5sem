package com.example.lab2_1;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;

import java.sql.SQLException;
import java.util.List;

@Controller
public class DoctorController {
    DoctorDAO doctorDAO = new DoctorDAO();

    @GetMapping("doctors")
    public String all(Model model) throws SQLException{
        List<Doctor> list = doctorDAO.All();
        model.addAttribute("listDoctor", list);
        return "DoctorIndex";
    }

    @GetMapping(value = "doctors/get{id}")
    public String get(@PathVariable Integer id, Model model) throws SQLException {
        Doctor doc = doctorDAO.Get(id);
        model.addAttribute("doctor", doc);
        return "DoctorForm";
    }

    @PostMapping(value = "doctors/post")
    public String post(@ModelAttribute Doctor doctor, Model model) throws SQLException {
        doctorDAO.Add(doctor);
        return "redirect:/doctors";
    }

    @PostMapping(value="doctors/edit{id}")
    public String edit(@PathVariable Integer id, Doctor doctor, Model model) throws SQLException {
        doctorDAO.Edit(doctor);
        return "redirect:/doctors";
    }

    @DeleteMapping(value="doctors/delete{id}")
    public String delete(@PathVariable Integer id, Model model) throws SQLException {
        doctorDAO.Delete(doctorDAO.Get(id));
        return "redirect:/doctors";
    }
}
