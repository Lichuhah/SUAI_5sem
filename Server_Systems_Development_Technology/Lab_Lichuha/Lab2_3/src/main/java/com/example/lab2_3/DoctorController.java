package com.example.lab2_3;

import org.springframework.http.MediaType;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;

import java.sql.SQLException;
import java.util.List;

@RestController
public class DoctorController {
    DoctorDAO doctorDAO = new DoctorDAO();

    @RequestMapping(value = "doctors/all", method = RequestMethod.GET)
    public List<Doctor> all() throws SQLException{
        List<Doctor> list = doctorDAO.All();
        return list;
    }

    @GetMapping(value = "doctors/get{id}")
    public Doctor get(@PathVariable int id) throws SQLException {
        Doctor doc = doctorDAO.Get(id);
        return doc;
    }

    @PostMapping(value = "doctors/post")
    public int post(@RequestBody Doctor doctor) throws SQLException {
        doctorDAO.Add(doctor);
        List<Doctor> items = doctorDAO.All();
        return items.get(items.size() - 1).id;
    }

    @PutMapping(value="doctors/edit", consumes = MediaType.APPLICATION_JSON_VALUE,
            produces = MediaType.APPLICATION_JSON_VALUE)
    public void edit(@RequestBody Doctor doctor) throws SQLException {
        doctorDAO.Edit(doctor);
    }

    @DeleteMapping(value="doctors/delete{id}")
    public boolean delete(@PathVariable Integer id) throws SQLException {
        doctorDAO.Delete(doctorDAO.Get(id));
        return true;
    }
}
