package com.example.lab4;

import org.springframework.http.HttpStatus;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
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
    public ResponseEntity post(@RequestBody Patient patient) throws SQLException {
        patientDAO.Add(patient);
        List<Patient> items = patientDAO.All();
        return ResponseEntity.status(HttpStatus.CREATED).body(items.get(items.size() - 1).id);
    }

    @PutMapping(value="patients/edit", consumes = MediaType.APPLICATION_JSON_VALUE,
            produces = MediaType.APPLICATION_JSON_VALUE)
    public ResponseEntity edit(@RequestBody Patient patient) throws SQLException {
        patientDAO.Edit(patient);
        return ResponseEntity.status(HttpStatus.ACCEPTED).body(null);
    }

    @DeleteMapping(value="patients/delete{id}")
    public ResponseEntity delete(@PathVariable Integer id) throws SQLException {
        patientDAO.Delete(patientDAO.Get(id));
        return ResponseEntity.status(HttpStatus.ACCEPTED).body(null);
    }
}

