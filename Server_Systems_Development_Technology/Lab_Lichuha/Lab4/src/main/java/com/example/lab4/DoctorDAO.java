package com.example.lab4;


import javax.print.Doc;
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
            Doctor newDoctor = getDoctorFromResultSet(resultSet);
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
            Doctor newDoctor = getDoctorFromResultSet(resultSet);
            result.add(newDoctor);
        }

        return result;
    };

    public boolean Add(Doctor doctor) throws SQLException {
        String command = "INSERT INTO Doctor (Name, Cabinet, Speciality, Surname, Midname) VALUES (?,?,?,?,?)";
        PreparedStatement statement = getStatWithDoctor(doctor,command);
        boolean result = statement.executeUpdate()>0;
        return result;
    };

    public boolean Edit(Doctor doctor) throws SQLException {
        String command = "UPDATE Doctor SET Name=?, Cabinet=?, Speciality=?, Surname=?, Midname=? WHERE Id=?";
        PreparedStatement statement = getStatWithDoctor(doctor, command);
        statement.setInt(6, doctor.id);
        boolean result = statement.executeUpdate()>0;
        return  result;
    };

    public boolean Delete(Doctor doctor) throws SQLException {
        String command = "DELETE FROM Doctor WHERE Id=?";
        PreparedStatement statement = SQLCon.getSqlConnection().prepareStatement(command);
        statement.setInt(1, doctor.id);
        boolean result = statement.executeUpdate()>0;
        return  result;
    };

    public PreparedStatement getStatWithDoctor(Doctor doctor, String command) throws SQLException {
        PreparedStatement statement = SQLCon.getSqlConnection().prepareStatement(command);
        statement.setString(1, doctor.name);
        statement.setInt(2, doctor.cabinet);
        statement.setString(3,doctor.speciality);
        statement.setString(4, doctor.surname);
        statement.setString(5, doctor.midname);
        return statement;
    };

    public Doctor getDoctorFromResultSet(ResultSet resultSet) throws SQLException {
        Doctor doctor = new Doctor();
        doctor.id=resultSet.getInt("Id");
        doctor.name=resultSet.getString("Name");
        doctor.cabinet=resultSet.getInt("Cabinet");
        doctor.speciality=resultSet.getString("Speciality");
        doctor.surname=resultSet.getString("Surname");
        doctor.midname=resultSet.getString("Midname");
        return doctor;
    };
}
