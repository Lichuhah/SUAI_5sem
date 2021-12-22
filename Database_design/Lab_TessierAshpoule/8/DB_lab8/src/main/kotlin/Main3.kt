import java.util.*
import javax.swing.JFrame
import javax.swing.JScrollPane
import javax.swing.JTable
import javax.swing.table.DefaultTableModel

fun main(args: Array<String>) {
    JTableExamples()
}

class JTableExamples internal constructor() {
    var f = JFrame()
    var j: JTable

    init {
        f.title = "DB hibernate"

        val session = HibernateSessionFactory.createSession()
        val query = session.createQuery("from Owner")
        val result = query.resultList

        println(result.toString())
        val v = Vector<Vector<String>> ()
        result.forEach { v.add(it.toVector()) }

        session.close()

        // Column Names
        val columnNames = Vector<String>(4)
        columnNames.add("id")
        columnNames.add("Фамилия")
        columnNames.add("Имя")
        columnNames.add("Отчество")

        // Initializing the JTable
        j = JTable(DefaultTableModel(v, columnNames))
        j.setBounds(30, 40, 200, 300)

        // adding it to JScrollPane
        val sp = JScrollPane(j)
        f.add(sp)                           // Frame Size
        f.setSize(500, 200)     // Frame Visible = true
        f.isVisible = true
    }
}

fun Any.toVector() : Vector<String>? {
    return if (this is Owner) {
        val vector = Vector<String>()
        vector.add(this.Id.toString())
        vector.add(this.Surnane)
        vector.add(this.Name)
        vector.add(this.Middle_name)
        vector
    } else {
        null
    }
}