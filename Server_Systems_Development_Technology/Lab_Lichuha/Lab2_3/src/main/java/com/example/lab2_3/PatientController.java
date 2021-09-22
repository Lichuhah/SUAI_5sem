package com.example.lab2_3;

import org.springframework.http.MediaType;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;

import java.sql.SQLException;
import java.util.List;

@RestController
public class PatientController {
    PatientDAO patientDAO = new PatientDAO();

    @RequestMapping(value = "patients/all", method = RequestMethod.GET)
    public List<Patient> all() throws SQLException{
        List<Patient> list = patientDAO.All();
        return list;
    }

    @GetMapping(value = "patients/get{id}")
    public Patient get(@PathVariable Integer id) throws SQLException {
        Patient patient = patientDAO.Get(id);
        return patient;
    }

    @PostMapping(value = "patients/post")
    public int post(@RequestBody Patient patient) throws SQLException {
        patientDAO.Add(patient);
        List<Patient> items = patientDAO.All();
        return items.get(items.size() - 1).id;
    }

    @PutMapping(value="patients/edit", consumes = MediaType.APPLICATION_JSON_VALUE,
            produces = MediaType.APPLICATION_JSON_VALUE)
    public void edit(@RequestBody Patient patient) throws SQLException {
        patientDAO.Edit(patient);
    }

    @DeleteMapping(value="patients/delete{id}")
    public boolean delete(@PathVariable Integer id) throws SQLException {
        patientDAO.Delete(patientDAO.Get(id));
        return true;
    }
}

