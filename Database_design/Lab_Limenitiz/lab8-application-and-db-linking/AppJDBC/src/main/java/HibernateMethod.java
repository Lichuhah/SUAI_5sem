import org.hibernate.Session;

import javax.persistence.Query;
import javax.swing.*;
import javax.swing.table.DefaultTableModel;
import java.sql.*;
import java.util.List;
import java.util.Vector;

public class HibernateMethod {

    public static void main(String[] args) throws SQLException {
        // It creates and displays the table
        JTable table = new JTable(getData());
        JOptionPane.showMessageDialog(null, new JScrollPane(table));
    }

    public static DefaultTableModel getData(){
        List<Author> rs = getItems();

        // Column Names
        Vector<String> columnNames = new Vector<String>(4);
        columnNames.add("id");
        columnNames.add("Фамилия");
        columnNames.add("Имя");
        columnNames.add("Отчество");

        Vector<Vector<String>> data = new Vector<>();
        for (var r : rs ) {
            Vector<String> a = new Vector<String>(4);
            a.add(Long.toString(r.getId_author()));
            a.add(r.getFirstNameAuthor());
            a.add(r.getSecondNameAuthor());
            a.add(r.getThirdNameAuthor());
            data.add(a);
        }

        return new DefaultTableModel(data, columnNames);
    }

    public static List<Author> getItems(){
        Session session = HibernateSessionFactory.createSession();
        Query query = session.createQuery("from Author"); // select * from authors
        var result = query.getResultList();
        session.close();
        return result;
    }
}
