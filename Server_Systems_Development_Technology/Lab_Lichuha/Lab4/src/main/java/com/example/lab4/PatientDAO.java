package com.example.lab4;


import java.sql.*;
import java.util.ArrayList;
import java.util.List;

public class PatientDAO {
    public Patient Get(int id) throws SQLException {
        Patient result = new Patient();
        String command = "SELECT * FROM Patient WHERE Id="+id;
        Statement statement = SQLCon.getSqlConnection().createStatement();
        ResultSet resultSet = statement.executeQuery(command);

        if(resultSet.next()){
            Patient newPatient = getPatientFromResultSet(resultSet);
            result = newPatient;
        }

        return result;
    };

    public List<Patient> All() throws SQLException {
        List<Patient> result = new ArrayList<>();
        String command = "SELECT * FROM [Patient]";
        Statement statement = SQLCon.getSqlConnection().createStatement();
        ResultSet resultSet = statement.executeQuery(command);

        while(resultSet.next()){
            Patient newPatient = getPatientFromResultSet(resultSet);
            result.add(newPatient);
        }

        return result;
    };

    public boolean Add(Patient patient) throws SQLException {
        String command = "INSERT INTO Patient (Name, Surname, Midname) VALUES (?,?,?)";
        PreparedStatement statement = getStatFromPatient(patient, command);

        boolean result = statement.executeUpdate()>0;
        return result;
    };

    public boolean Edit(Patient patient) throws SQLException {
        String command = "UPDATE Patient SET Name=?, Surname=?, Midname=? WHERE Id=?";
        PreparedStatement statement = getStatFromPatient(patient, command);
        statement.setInt(4, patient.id);
        boolean result = statement.executeUpdate()>0;
        return  result;
    };

    public boolean Delete(Patient patient) throws SQLException {
        String command = "DELETE FROM Patient WHERE Id=?";
        PreparedStatement statement = SQLCon.getSqlConnection().prepareStatement(command);
        statement.setInt(1,patient.id);

        boolean result = statement.executeUpdate()>0;
        return  result;
    };

    public Patient getPatientFromResultSet(ResultSet resultSet) throws SQLException {
        Patient patient = new Patient();
        patient.id=resultSet.getInt("Id");
        patient.name=resultSet.getString("Name");
        patient.midname=resultSet.getString("Midname");
        patient.surname=resultSet.getString("Surname");
        return patient;
    }

    public PreparedStatement getStatFromPatient(Patient patient, String command) throws SQLException {
        PreparedStatement statement = SQLCon.getSqlConnection().prepareStatement(command);
        statement.setString(1, patient.name);
        statement.setString(2, patient.surname);
        statement.setString(3, patient.midname);
        return statement;
    }
}
