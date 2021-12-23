import javax.swing.*;
import javax.swing.table.DefaultTableModel;
import java.sql.*;
import java.util.Vector;

public class BindindMethod {
    // JDBC URL, username and password of MySQL server
    private static final String url = "jdbc:mysql://localhost:3306/database_design_course";
    private static final String user = "root_user";
    private static final String password = "root_user";

    public static void main(String[] args) throws SQLException {
        String query = "select * from author";

        // opening database connection to MySQL server
        Connection con = DriverManager.getConnection(url, user, password);
        // getting Statement object to execute query
        Statement stmt = con.createStatement();
        // executing SELECT query
        ResultSet rs = stmt.executeQuery(query);

        // It creates and displays the table
        JTable table = new JTable(buildTableModel(rs));
        JOptionPane.showMessageDialog(null, new JScrollPane(table));

        con.close();
        stmt.close();
        rs.close();
    }

    public static DefaultTableModel buildTableModel(ResultSet rs)
            throws SQLException {

        ResultSetMetaData metaData = rs.getMetaData();

        // names of columns
        Vector<String> columnNames = new Vector<String>();
        int columnCount = metaData.getColumnCount();
        for (int column = 1; column <= columnCount; column++) {
            columnNames.add(metaData.getColumnName(column));
        }

        // data of the table
        Vector<Vector<Object>> data = new Vector<Vector<Object>>();
        while (rs.next()) {
            Vector<Object> vector = new Vector<Object>();
            for (int columnIndex = 1; columnIndex <= columnCount; columnIndex++) {
                vector.add(rs.getObject(columnIndex));
            }
            data.add(vector);
        }

        return new DefaultTableModel(data, columnNames);

    }
}
