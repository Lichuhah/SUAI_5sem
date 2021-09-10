package api.lab.Models;

public class Doctor {
    public Integer id;
    public String name;
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
}
