package lab.example.lab1

import javax.servlet.annotation.WebServlet
import javax.servlet.http.HttpServlet
import javax.servlet.http.HttpServletRequest
import javax.servlet.http.HttpServletResponse

@WebServlet(name = "getObj", value = ["/getObj"])
class GetObjServlet: HttpServlet() {
    public override fun doPost(request: HttpServletRequest, response: HttpServletResponse) {
        val id = request.getParameter("roomId").toInt()
        val objName = request.getParameter("objName")
        val objCount = request.getParameter("objCount").toInt()

        println("room=$id;objName=$objName;objCount=$objCount")
        for (r in Storage.roomList)
            if (r.id == id)
                r.get(objName, objCount)


        response.sendRedirect("room?roomId=$id")
    }

    override fun destroy() {
    }
}