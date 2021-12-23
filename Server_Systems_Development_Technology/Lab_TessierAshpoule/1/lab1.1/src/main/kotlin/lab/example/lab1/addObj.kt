package lab.example.lab1

import objFactory
import javax.servlet.annotation.WebServlet
import javax.servlet.http.HttpServlet
import javax.servlet.http.HttpServletRequest
import javax.servlet.http.HttpServletResponse

@WebServlet(name = "addObj", value = ["/addObj"])
class AddObjServlet: HttpServlet() {
    public override fun doPost(request: HttpServletRequest, response: HttpServletResponse) {

        val objName = request.getParameter("objName")
        val id = request.getParameter("roomId").toInt()
        val objCount = request.getParameter("objCount").toInt()

        val obj = objFactory(objName, objCount)

        println("room=$id;objName=$objName;objCount=$objCount")
        if ( obj != null )
            for (r in Storage.roomList)
                if (r.id == id)
                    r.put(obj)


        response.sendRedirect("room?roomId=$id")
    }

    override fun destroy() {
    }
}