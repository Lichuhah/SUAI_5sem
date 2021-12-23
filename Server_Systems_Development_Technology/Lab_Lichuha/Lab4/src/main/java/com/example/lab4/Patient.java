package com.example.lab4;

import javax.persistence.Id;
import javax.persistence.Table;
import javax.persistence.Entity;
import java.util.Date;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
@Entity
@Table(name = "Patient")
public class Patient {
    @Id
    @GeneratedValue(strategy=GenerationType.AUTO)
    public Integer id;
    public String name;
    public String surname;
    public String midname;

    public Integer getId(){
        return id;
    }

    public String getName(){
        return name;
    }

    public void setId(int id) {
        this.id = id;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getSurname() {
        return surname;
    }

    public void setSurname(String surname) {
        this.surname = surname;
    }

    public String getMidname() {
        return midname;
    }

    public void setMidname(String midname) {
        this.midname = midname;
    }
}
