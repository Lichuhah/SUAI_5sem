package lab.example.lab1

import javax.servlet.annotation.WebServlet
import javax.servlet.http.HttpServlet
import javax.servlet.http.HttpServletRequest
import javax.servlet.http.HttpServletResponse

@WebServlet(name = "addRoom", value = ["/addRoom"])
class AddRoomServlet: HttpServlet() {
    public override fun doPost(request: HttpServletRequest, response: HttpServletResponse) {
        val name = request.getParameter("roomName")
        val id   = request.getParameter("roomId").toInt()

        if ( Storage.addRoom(name, id)) {
            println("Add new room\n\tname = $name\n\tid   = $id\n");
        }

        response.sendRedirect("storage")

    }

    override fun destroy() {
    }
}