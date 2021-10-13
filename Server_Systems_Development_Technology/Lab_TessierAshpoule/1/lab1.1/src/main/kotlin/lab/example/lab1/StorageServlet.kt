package lab.example.lab1

import javax.servlet.http.*
import javax.servlet.annotation.*

@WebServlet(name = "storage", value = ["/storage"])
class StorageServlet: HttpServlet() {

    override fun init() {
    }

    public override fun doGet(request: HttpServletRequest, response: HttpServletResponse) {
        response.contentType = "text/html"
        val out = response.writer

        if ( Storage.size() != 0 ) {
            out.println("<h5> Room list</h5>")
            Storage.roomList.forEach {
                out.println("<a>${it.name}   ${it.id}</a> </br>")
            }
        }

        out.println("""
            |<h1>Add Room </h1>
            |<form name="loginForm" method="post" action="addRoom">
	        |Room name: <input type="text" name="roomName"/> <br/>
	        |Room id: <input type="text" name="roomId"/> <br/>
	        |<input type="submit" value="Add" />
            |</form>
            |<br/>""".trimMargin())

        out.println("""
            |<h1>Delete Room </h1>
            |<form name="loginForm" method="post" action="deleteRoom">
	        |Room Id: <input type="text" name="roomId"/> <br/>
	        |<input type="submit" value="Delete" />
            |</form>
            |<br/>""".trimMargin())

        out.println("""
            |<h1>Open Room </h1>
            |<form name="loginForm" method="get" action="room">
	        |RoomId: <input type="text" name="roomId"/> <br/>
	        |<input type="submit" value="Open" />
            |</form>
            |<br/>""".trimMargin())

        out.println("</body></html>")
        /*
        val action = "login"
        out.println("""<html><body>
            |<form name="loginForm" method="post" action="$action">
	        |Username: <input type="text" name="username"/> <br/>
	        |Password: <input type="password" name="password"/> <br/>
	        |<input type="submit" value="Login" />
            |</form>
            |</body></html>""".trimMargin())
            */
    }

    override fun destroy() {
    }
}