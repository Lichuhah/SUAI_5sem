package lab.example.lab1

import javax.servlet.annotation.WebServlet
import javax.servlet.http.HttpServlet
import javax.servlet.http.HttpServletRequest
import javax.servlet.http.HttpServletResponse


@WebServlet(name = "error", value = ["/error"])
class ErrorServlet: HttpServlet() {
    public override fun doGet(request: HttpServletRequest, response: HttpServletResponse) {
        response.contentType = "text/html"
        val out = response.writer
        out.println(
            "<html><body>" +
            "<a>Hello ${erroreStorage.getError()}</a>" +
            "<br/>" +
            "<a href=\"storage\" >main page</a> "+
            "</body></html>"
        )
    }
}