package com.example.lab4;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

public class AppointmentDAO {

    public List<Doctor_Patient> All() throws SQLException {
        List<Doctor_Patient> result = new ArrayList<>();
        String command = "SELECT * FROM [Doctor_Patient]";
        Statement statement = SQLCon.getSqlConnection().createStatement();
        ResultSet resultSet = statement.executeQuery(command);

        while(resultSet.next()){
            Doctor_Patient newAppointment = new Doctor_Patient();
            newAppointment.id= resultSet.getInt("Id");
            newAppointment.pat= new PatientDAO().Get(resultSet.getInt("Id_Patient"));
            newAppointment.doc= new DoctorDAO().Get(resultSet.getInt("Id_Doctor"));
            newAppointment.info = resultSet.getString("Info");
            result.add(newAppointment);
        }

        return result;
    };

    public boolean Add(Doctor_Patient doctor_patient) throws SQLException {
        String command = "INSERT INTO Doctor_Patient (Id_Doctor, Id_Patient, Info) VALUES (?,?,?)";
        PreparedStatement statement = SQLCon.getSqlConnection().prepareStatement(command);
        statement.setInt(1, doctor_patient.doc.id);
        statement.setInt(2, doctor_patient.pat.id);
        statement.setString(3, doctor_patient.info);


        boolean result = statement.executeUpdate()>0;
        return result;
    };

    public boolean Delete(Doctor_Patient doctor_patient) throws SQLException {
        String command = "DELETE FROM Doctor_Patient WHERE Id=?";
        PreparedStatement statement = SQLCon.getSqlConnection().prepareStatement(command);
        statement.setInt(1,doctor_patient.id);

        boolean result = statement.executeUpdate()>0;
        return  result;
    };
}
