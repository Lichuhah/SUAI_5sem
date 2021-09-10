package api.lab1;

import api.lab.Models.Patient;

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
            Patient newPatient = new Patient();
            newPatient.id=resultSet.getInt("Id");
            newPatient.name=resultSet.getString("Name");
            newPatient.birthday=resultSet.getDate("Birthday");
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
            Patient newPatient = new Patient();
            newPatient.id=resultSet.getInt("Id");
            newPatient.name=resultSet.getString("Name");
            newPatient.birthday=resultSet.getDate("Birthday");
            result.add(newPatient);
        }

        return result;
    };

    public boolean Add(Patient patient) throws SQLException {
        String command = "INSERT INTO Patient (Name, Birthday) VALUES (?,?)";
        PreparedStatement statement = SQLCon.getSqlConnection().prepareStatement(command);
        statement.setString(1, patient.name);
        statement.setDate(2, null);

        boolean result = statement.executeUpdate()>0;
        return result;
    };

    public boolean Edit(Patient patient) throws SQLException {
        String command = "UPDATE Patient SET Name=?, Birthday=? WHERE Id=?";
        PreparedStatement statement = SQLCon.getSqlConnection().prepareStatement(command);
        statement.setString(1, patient.name);
        statement.setDate(2, null);
        statement.setInt(3,patient.id);

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
}
