import java.sql.DriverManager
import java.sql.ResultSet
import java.sql.ResultSetMetaData
import java.util.*
import javax.swing.JFrame
import javax.swing.JScrollPane
import javax.swing.JTable
import javax.swing.table.DefaultTableModel

private val JDBC_DRIVER = "com.mysql.cj.jdbc.Driver"
private val DATABASE_URL = "jdbc:mysql://localhost/bd_schema"

private val USER = "admin"
private val PASSWORD = "admin"

fun main() {
    println("Registering JDBC driver...")
    Class.forName(JDBC_DRIVER)
    println("Creating database connection...")
    val connection = DriverManager.getConnection(DATABASE_URL, USER, PASSWORD)
    println("Executing statement...")
    val statement = connection.createStatement()
    val resultSet: ResultSet = statement.executeQuery("SELECT * FROM owner")

    val f: JFrame = JFrame()
    f.title = "DB2"
    val sp = JScrollPane(JTable(buildTableModel(resultSet)))
    f.add(sp)                           // Frame Size
    f.setSize(500, 200)     // Frame Visible = true
    f.isVisible = true

    resultSet.close()
    connection.close()
    statement.close()
}

fun buildTableModel(rs: ResultSet): DefaultTableModel {
    val metaData: ResultSetMetaData = rs.metaData

    // names of columns
    val columnNames = Vector<String>()
    val columnCount = metaData.columnCount
    for (column in 1..columnCount) {
        columnNames.add(metaData.getColumnName(column))
    }

    // data of the table
    val data = Vector<Vector<Any>>()
    while (rs.next()) {
        val vector = Vector<Any>()
        for (columnIndex in 1..columnCount) {
            vector.add(rs.getObject(columnIndex))
        }
        data.add(vector)
    }
    return DefaultTableModel(data, columnNames)
}