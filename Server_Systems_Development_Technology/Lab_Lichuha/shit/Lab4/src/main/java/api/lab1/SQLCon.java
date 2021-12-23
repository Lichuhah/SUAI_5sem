package api.lab1;

import java.sql.*;

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

}