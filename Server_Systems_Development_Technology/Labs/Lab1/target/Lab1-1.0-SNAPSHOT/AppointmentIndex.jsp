<%@ page language="java" contentType="text/html; charset=UTF-8"
pageEncoding="UTF-8"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<html>
<head>
    <title>Appointment Application</title>
</head>
<body>
<center>
    <h1>Appointments Management</h1>
    <h2>
        <a href="NewAppointmentFormServlet">Add New Appointment</a>
        &nbsp;&nbsp;&nbsp;
        <a href="AllAppointmentServlet">List All Appointment</a>

    </h2>
</center>
<div align="center">
    <table border="1" cellpadding="5">
        <caption><h2>List of Appointment</h2></caption>
        <tr>
            <th>Id</th>
            <th>Id Doctor</th>
            <th>Name Doctor</th>
            <th>Id Patient</th>
            <th>Name Patient</th>
            <th>Info</th>
        </tr>
        <c:forEach var="app" items="${listApp}">
            <tr>
                <td><c:out value="${app.id}" /></td>
                <td><c:out value="${app.doc.id}" /></td>
                <td><c:out value="${app.doc.name}" /></td>
                <td><c:out value="${app.pat.id}" /></td>
                <td><c:out value="${app.pat.name}" /></td>
                <td><c:out value="${app.info}" /></td>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;
                    <a href="DeleteAppointmentServlet?id=<c:out value='${app.id}' />">Delete</a>
                </td>
            </tr>
        </c:forEach>
    </table>
</div>
</body>
</html>