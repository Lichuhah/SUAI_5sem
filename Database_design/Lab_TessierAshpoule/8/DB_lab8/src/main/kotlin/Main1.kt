import java.sql.Connection
import java.sql.DriverManager
import java.sql.Statement
import java.util.*
import javax.swing.JFrame
import javax.swing.JScrollPane
import javax.swing.JTable
import javax.swing.table.DefaultTableModel

fun main(args: Array<String>) {
    JTableExamples()
}

class JTableExamples internal constructor() {
    var f: JFrame = JFrame()

    init {
        f.title = "DB1"

        val db = Jdbc()
        val data =  db.readOwner()

        val columnNames = Vector<String>(4)
        columnNames.add("id")
        columnNames.add("Фамилия")
        columnNames.add("Имя")
        columnNames.add("Отчество")

        val j = JTable(DefaultTableModel(data, columnNames))
        j.setBounds(30, 40, 200, 300)

        val sp = JScrollPane(j)
        f.add(sp)
        f.setSize(500, 200)
        f.isVisible = true
    }
}

class Jdbc {
    /**  JDBC Driver and database url */
    private val JDBC_DRIVER = "com.mysql.cj.jdbc.Driver"
    private val DATABASE_URL = "jdbc:mysql://localhost/bd_schema"

    private val USER = "admin"
    private val PASSWORD = "admin"

    private var statement  :  Statement
    private var connection : Connection

    init {
        println("Registering JDBC driver...")
        Class.forName(JDBC_DRIVER)
        println("Creating database connection...")
        connection = DriverManager.getConnection(DATABASE_URL, USER, PASSWORD)
        println("Executing statement...")
        statement = connection.createStatement()
    }

    fun finalize() {
        println("Closing connection and releasing resources...")
        statement.close()
        connection.close()
    }

    fun readOwner() : Vector<Vector<String>> {
        val sql = "SELECT * FROM owner"
        val resultSet = statement.executeQuery(sql)
        println("Retrieving data from database...")
        val ownerList = Vector<Vector<String>> ()
        var i = 0
        while (resultSet.next()) {
            val a = Vector<String>(4)
            a.add(resultSet.getInt("id_owner").toString())
            a.add(resultSet.getString("Surname"))
            a.add(resultSet.getString("Name"))
            a.add(resultSet.getString("Middle_name"))
            ownerList.add(a)
        }
        resultSet.close()
        return ownerList;
    }
}