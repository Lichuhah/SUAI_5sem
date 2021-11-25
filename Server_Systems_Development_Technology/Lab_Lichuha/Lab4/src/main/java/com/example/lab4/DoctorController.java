package com.example.lab4;

import com.example.lab4.DAOHib.DoctorDAOHib;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import javax.persistence.criteria.CriteriaQuery;

import java.sql.SQLException;
import java.util.List;
import java.util.Optional;

import org.hibernate.*;
import org.hibernate.boot.MetadataSources;
import org.hibernate.boot.registry.StandardServiceRegistry;
import org.hibernate.boot.registry.StandardServiceRegistryBuilder;

@RestController
public class DoctorController {
    DoctorDAO doctorDAO = new DoctorDAO();
    @Autowired
    DoctorDAOHib doctorDAOHib;
    @RequestMapping(value = "doctors/all", method = RequestMethod.GET)
    public List<Doctor> all() throws SQLException{
        List<Doctor> list = doctorDAO.All();
        List<Doctor> list1 = (List<Doctor>) doctorDAOHib.findAll();
        return list1;
    }

    @GetMapping(value = "doctors/get{id}")
    public Doctor get(@PathVariable int id) throws SQLException {
        Doctor doc = doctorDAO.Get(id);
        return doc;
    }

    @PostMapping(value = "doctors/post")
    public ResponseEntity post(@RequestBody Doctor doctor) throws SQLException {
        doctorDAO.Add(doctor);
        List<Doctor> items = doctorDAO.All();
        return ResponseEntity.status(HttpStatus.ACCEPTED).body(items.get(items.size() - 1).id);
    }

    @PutMapping(value="doctors/edit", consumes = MediaType.APPLICATION_JSON_VALUE,
            produces = MediaType.APPLICATION_JSON_VALUE)
    public ResponseEntity edit(@RequestBody Doctor doctor) throws SQLException {
        doctorDAO.Edit(doctor);
        return ResponseEntity.status(HttpStatus.ACCEPTED).body(null);
    }

    @DeleteMapping(value="doctors/delete{id}")
    public ResponseEntity delete(@PathVariable Integer id) throws SQLException {
        doctorDAO.Delete(doctorDAO.Get(id));
        return ResponseEntity.status(HttpStatus.ACCEPTED).body(null);
    }
}
