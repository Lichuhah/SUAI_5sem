package api.lab.Models;

import java.util.Date;

public class Patient {
    public int id;
    public String name;
    public Date birthday;

    public Integer getId(){
        return id;
    }

    public String getName(){
        return name;
    }

    public Date getBirthday() {
        return birthday;
    }

    public void setId(int id) {
        this.id = id;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setBirthday(Date birthday) {
        this.birthday = birthday;
    }
}
