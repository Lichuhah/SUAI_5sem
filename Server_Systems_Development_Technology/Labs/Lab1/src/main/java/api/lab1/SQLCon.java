package api.lab1;

import api.lab.Models.Doctor;
import api.lab.Models.Doctor_Patient;
import api.lab.Models.Patient;

import java.sql.*;
import java.util.ArrayList;
import java.util.List;

import static java.lang.Class.forName;

public class SQLCon {
    static String connectionString = "jdbc:sqlserver://127.0.0.1\\SQLEXPRESS;databaseName=PolyclinicDB;username=sa;password=test";

    public SQLCon() {
        String connectionUrl = "jdbc:sqlserver://127.0.0.1\\SQLEXPRESS;databaseName=PolyclinicDB;username=sa;password=test";
        this.connectionString=connectionUrl;
        try {
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
        } catch (ClassNotFoundException e) {
            e.printStackTrace();
        }
    }

    public static Connection getSqlConnection() throws SQLException {
        String connectionString = "jdbc:sqlserver://127.0.0.1\\SQLEXPRESS;databaseName=PolyclinicDB;username=sa;password=test";
        try {
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
        } catch (ClassNotFoundException e) {
            e.printStackTrace();
        }
        Connection connection = DriverManager.getConnection(connectionString);
        return connection;
    }

    public List<Patient> getPatients(){
        List<Patient> patients = new ArrayList<>();;
        ResultSet resultSet = null;
        String data = null;

        try (Connection connection = DriverManager.getConnection(connectionString);
             Statement statement = connection.createStatement();) {

            // Create and execute a SELECT SQL statement.
            String selectSql = "SELECT * FROM [Patient]";
            resultSet = statement.executeQuery(selectSql);

            // Print results from select statement
            while (resultSet.next()) {
                Patient newPatient = new Patient();
                newPatient.id=resultSet.getInt("Id");
                newPatient.name=resultSet.getString("Name");
                newPatient.birthday=resultSet.getDate("Birthday");
                patients.add(newPatient);
            }

        }
        catch (SQLException e) {
            throw new RuntimeException("Не удалось загрузить FabricMySQLDriver ", e);
        }
        return patients;
    }

    public Patient getPatient(int id){
        ResultSet resultSet = null;
        String data = null;
        Patient newPatient = new Patient();

        try (Connection connection = DriverManager.getConnection(connectionString);
             Statement statement = connection.createStatement();) {

            // Create and execute a SELECT SQL statement.
            String selectSql = "SELECT * FROM [Patient] WHERE Patient.Id="+id;
            resultSet = statement.executeQuery(selectSql);


            // Print results from select statement
            while (resultSet.next()) {
                newPatient = new Patient();
                newPatient.id=resultSet.getInt("Id");
                newPatient.name=resultSet.getString("Name");
                newPatient.birthday=resultSet.getDate("Birthday");
            }

        }
        catch (SQLException e) {
            throw new RuntimeException("Не удалось загрузить FabricMySQLDriver ", e);
        }
        return newPatient;
    }

    public List<Doctor> getDoctors(){
        List<Doctor> doctors = new ArrayList<>();
        ResultSet resultSet = null;
        String data = null;

        try (Connection connection = DriverManager.getConnection(connectionString);
             Statement statement = connection.createStatement();) {

            // Create and execute a SELECT SQL statement.
            String selectSql = "SELECT * FROM [Doctor]";
            resultSet = statement.executeQuery(selectSql);

            // Print results from select statement
            while (resultSet.next()) {
                Doctor newDoctor = new Doctor();
                newDoctor.id=resultSet.getInt("Id");
                newDoctor.name=resultSet.getString("Name");
                newDoctor.speciality=resultSet.getString("Speciality");
                newDoctor.cabinet=resultSet.getInt("Cabinet");
                doctors.add(newDoctor);
            }

        }
        catch (SQLException e) {
            throw new RuntimeException("Не удалось загрузить FabricMySQLDriver ", e);
        }
        return doctors;
    }

    public Doctor getDoctor(int id){
        Doctor doctor=null;
        ResultSet resultSet = null;
        String data = null;

        try (Connection connection = DriverManager.getConnection(connectionString);
             Statement statement = connection.createStatement();) {

            // Create and execute a SELECT SQL statement.
            String com = "SELECT * FROM [Doctor] WHERE Doctor.Id="+id;
            String selectSql = com;
            resultSet = statement.executeQuery(selectSql);

            // Print results from select statement
            while (resultSet.next()) {
                doctor = new Doctor();
                doctor.id=resultSet.getInt("Id");
                doctor.name=resultSet.getString("Name");
                doctor.speciality=resultSet.getString("Speciality");
                doctor.cabinet=resultSet.getInt("Cabinet");
            }

        }
        catch (SQLException e) {
            throw new RuntimeException("Не удалось загрузить FabricMySQLDriver ", e);
        }
        return doctor;
    }

    public List<Doctor_Patient> getDocPat(){
        List<Doctor_Patient> list = new ArrayList<>();
        ResultSet resultSet = null;
        try (Connection connection = DriverManager.getConnection(connectionString);
             Statement statement = connection.createStatement();) {

            // Create and execute a SELECT SQL statement.
            String selectSql = "SELECT * FROM [Doctor_Patient]";
            resultSet = statement.executeQuery(selectSql);

            // Print results from select statement
            while (resultSet.next()) {
                Doctor_Patient doctor_patient = new Doctor_Patient();
                doctor_patient.doc=getDoctor(resultSet.getInt("Id_Doctor"));
                doctor_patient.pat=getPatient(resultSet.getInt("Id_Patient"));
                doctor_patient.reason=resultSet.getString("Reason");
                doctor_patient.time=resultSet.getDate("Time");

                list.add(doctor_patient);
            }

        }
        catch (SQLException e) {
            throw new RuntimeException("Не удалось загрузить FabricMySQLDriver ", e);
        }
        return list;
    }
}