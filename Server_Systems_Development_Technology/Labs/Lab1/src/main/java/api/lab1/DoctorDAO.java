package api.lab1;

import api.lab.Models.Doctor;
import api.lab.Models.Patient;

import java.sql.*;
import java.util.ArrayList;
import java.util.List;

public class DoctorDAO {
    public Doctor Get(int id) throws SQLException {
        Doctor result = new Doctor();
        String command = "SELECT * FROM Doctor WHERE Id="+id;
        Statement statement = SQLCon.getSqlConnection().createStatement();
        ResultSet resultSet = statement.executeQuery(command);

        if(resultSet.next()){
            Doctor newDoctor = new Doctor();
            newDoctor.id=resultSet.getInt("Id");
            newDoctor.name=resultSet.getString("Name");
            newDoctor.cabinet=resultSet.getInt("Cabinet");
            newDoctor.speciality=resultSet.getString("Speciality");
            result = newDoctor;
        }

        return result;
    };

    public List<Doctor> All() throws SQLException {
        List<Doctor> result = new ArrayList<>();
        String command = "SELECT * FROM [Doctor]";
        Statement statement = SQLCon.getSqlConnection().createStatement();
        ResultSet resultSet = statement.executeQuery(command);

        while(resultSet.next()){
            Doctor newDoctor = new Doctor();
            newDoctor.id=resultSet.getInt("Id");
            newDoctor.name=resultSet.getString("Name");
            newDoctor.cabinet=resultSet.getInt("Cabinet");
            newDoctor.speciality=resultSet.getString("Speciality");
            result.add(newDoctor);
        }

        return result;
    };

    public boolean Add(Doctor doctor) throws SQLException {
        String command = "INSERT INTO Doctor (Name, Cabinet, Speciality) VALUES (?,?,?)";
        PreparedStatement statement = SQLCon.getSqlConnection().prepareStatement(command);
        statement.setString(1, doctor.name);
        statement.setInt(2, doctor.cabinet);
        statement.setString(3, doctor.speciality);


        boolean result = statement.executeUpdate()>0;
        return result;
    };

    public boolean Edit(Doctor doctor) throws SQLException {
        String command = "UPDATE Doctor SET Name=?, Cabinet=?, Speciality=? WHERE Id=?";
        PreparedStatement statement = SQLCon.getSqlConnection().prepareStatement(command);
        statement.setString(1, doctor.name);
        statement.setInt(2, doctor.cabinet);
        statement.setString(3,doctor.speciality);

        boolean result = statement.executeUpdate()>0;
        return  result;
    };

    public boolean Delete(Doctor doctor) throws SQLException {
        String command = "DELETE FROM Doctor WHERE Id=?";
        PreparedStatement statement = SQLCon.getSqlConnection().prepareStatement(command);
        statement.setInt(1,doctor.id);

        boolean result = statement.executeUpdate()>0;
        return  result;
    };
}
