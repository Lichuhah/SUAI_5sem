package com.example.lab4.DAOHib;


import com.example.lab4.Doctor;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface DoctorDAOHib extends CrudRepository<Doctor,Integer> {

}
