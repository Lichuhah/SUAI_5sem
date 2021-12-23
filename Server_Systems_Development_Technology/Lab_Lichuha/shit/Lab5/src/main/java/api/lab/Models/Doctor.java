package api.lab.Models;

public class Doctor {
    public Integer id;
    public String name;
    public String surname;
    public String midname;
    public String speciality;
    public Integer cabinet;

    public Integer getId(){
        return id;
    }

    public String getName(){
        return name;
    }

    public String getSpeciality() {
        return speciality;
    }

    public Integer getCabinet() {
        return cabinet;
    }

    public void setId(Integer id) {
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

    public void setSpeciality(String speciality) {
        this.speciality = speciality;
    }

    public void setCabinet(Integer cabinet) {
        this.cabinet = cabinet;
    }
}
