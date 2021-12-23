import javax.swing.*;
import javax.swing.table.DefaultTableModel;
import java.sql.*;
import java.util.Vector;

/**
 * Simple Java program to connect to MySQL database running on localhost and
 * running SELECT and INSERT query to retrieve and add data.
 * @author Javin Paul
 */
public class LoopMethod {
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

        loopMethod(rs);

        con.close();
        stmt.close();
        rs.close();
    }

    public static void loopMethod(ResultSet rs) throws SQLException {
        Vector<Vector<String>> ownerList = new Vector<>();
        var i = 0;
        while (rs.next()) {
            Vector<String> a = new Vector<String>(4);
            a.add(Integer.toString(rs.getInt("id_author")));
            a.add(rs.getString("firstNameAuthor"));
            a.add(rs.getString("secondNameAuthor"));
            a.add(rs.getString("thirdNameAuthor"));
            ownerList.add(a);
        }
        rs.close();

        // Column Names
        Vector<String> columnNames = new Vector<String>(4);
        columnNames.add("id");
        columnNames.add("Фамилия");
        columnNames.add("Имя");
        columnNames.add("Отчество");


        JTable table = new JTable(new DefaultTableModel(ownerList, columnNames));
        JOptionPane.showMessageDialog(null, new JScrollPane(table));
    }
}
