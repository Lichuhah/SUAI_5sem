package lab.example.lab1

import javax.servlet.annotation.WebServlet
import javax.servlet.http.HttpServlet
import javax.servlet.http.HttpServletRequest
import javax.servlet.http.HttpServletResponse

@WebServlet(name = "deleteRoom", value = ["/deleteRoom"])
class DeleteRoomServlet: HttpServlet() {
    public override fun doPost(request: HttpServletRequest, response: HttpServletResponse) {
        val id = request.getParameter("roomId").toInt()

        println("del $$id")
        if ( Storage.deleteRoom(id))
            println("Delete room id = $id\n")

        val out = response.writer
        out.println("""<html><body>
            |<a> Room [$id] was deleted</a>
            |</dr>
            |<a href="storage"> go back</a>
            |</body></html>""".trimMargin())
    }

    override fun destroy() {
    }
}