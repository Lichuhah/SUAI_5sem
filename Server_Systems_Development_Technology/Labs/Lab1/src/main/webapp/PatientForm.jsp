<%@ page language="java" contentType="text/html; charset=UTF-8"
         pageEncoding="UTF-8"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<html>
<head>
    <title>Books Store Application</title>
</head>
<body>
<center>
    <h1>Patient Management</h1>
    <h2>
        <a href="PatientsServlet/add">Add New Book</a>
        &nbsp;&nbsp;&nbsp;
        <a href="PatientsServlet/all">List All Books</a>

    </h2>
</center>
<div align="center">
    <c:if test="${patient != null}">
    <form action="update" method="post">
        </c:if>
        <c:if test="${patient == null}">
        <form action="insert" method="post">
            </c:if>
            <table border="1" cellpadding="5">
                <caption>
                    <h2>
                        <c:if test="${patient != null}">
                            Edit Book
                        </c:if>
                        <c:if test="${patient == null}">
                            Add New Book
                        </c:if>
                    </h2>
                </caption>
                <c:if test="${patient != null}">
                    <input type="hidden" name="id" value="<c:out value='${patient.id}' />" />
                </c:if>
                <tr>
                    <th>Name: </th>
                    <td>
                        <input type="text" name="name" size="45"
                               value="<c:out value='${patient.name}' />"
                        />
                    </td>
                </tr>
                <tr>
                    <th>Birthday: </th>
                    <td>
                        <input type="date" name="date" size="45"
                               value="<c:out value='${patient.birthday}' />"
                        />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <input type="submit" value="Save" />
                    </td>
                </tr>
            </table>
        </form>
</div>
</body>
</html>