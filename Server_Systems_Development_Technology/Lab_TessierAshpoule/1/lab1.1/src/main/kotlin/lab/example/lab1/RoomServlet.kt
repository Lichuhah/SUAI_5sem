package lab.example.lab1

import javax.servlet.annotation.WebServlet
import javax.servlet.http.HttpServlet
import javax.servlet.http.HttpServletRequest
import javax.servlet.http.HttpServletResponse

@WebServlet(name = "room", value = ["/room"])
class RoomServlet: HttpServlet() {
    public override fun doGet(request: HttpServletRequest, response: HttpServletResponse) {
        val id  = request.getParameter("roomId").toInt()
        val out = response.writer
        println("print room id = $id\n")
        out.println("<html><body>")
            for (r in Storage.roomList)
                if ( r.id == id )
                    if ( r.size() != 0 )
                        r.listObj.forEach {
                            out.println("<a> ${it.name}   ${it.count}</a> </br>")
                        }
                    else
                        out.println("<h1>This room is empty </h1>")

        out.println("""
            |<h3>Put Object </h3>
            |<form name="loginForm" method="post" action="addObj?roomId=$id">
	        |Room Id: <input type="text" name="roomId"/> <br/>
	        |Object name: <input type="text" name="objName"/> <br/>
	        |Object count: <input type="text" name="objCount"/> <br/>
	        |<input type="submit" value="Put" />
            |</form>
            |<br/>""".trimMargin())

        out.println("""
            |<h3>Get Room </h3>
            |<form name="loginForm" method="post" action="getObj">
	        |Room Id: <input type="text" name="roomId"/> <br/>
	        |Object Name: <input type="text" name="objName"/> <br/>
	        |Object count: <input type="text" name="objCount"/> <br/>
	        |<input type="submit" value="Get" />
            |</form>
            |<br/>""".trimMargin())

        out.println("""|</dr>
            |<a href="storage"> go back</a>
            |</body></html>""".trimMargin())

    }

    override fun destroy() {
    }
}