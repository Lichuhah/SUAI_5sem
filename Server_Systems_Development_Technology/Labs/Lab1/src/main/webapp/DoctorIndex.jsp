<%@ page language="java" contentType="text/html; charset=UTF-8"
         pageEncoding="UTF-8"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<html>
<head>
    <title>Doctor Application</title>
</head>
<body>
<center>
    <h1>Doctors Management</h1>
    <h2>
        <a href="NewDoctorFormServlet">Add New Doctor</a>
        &nbsp;&nbsp;&nbsp;
        <a href="AddDoctorServlet">List All Doctor</a>

    </h2>
</center>
<div align="center">
    <table border="1" cellpadding="5">
        <caption><h2>List of Doctors</h2></caption>
        <tr>
            <th>Id</th>
            <th>Name</th>
            <th>Cabinet</th>
            <th>Speciality</th>
        </tr>
        <c:forEach var="doctor" items="${listDoctor}">
            <tr>
                <td><c:out value="${doctor.id}" /></td>
                <td><c:out value="${doctor.name}" /></td>
                <td><c:out value="${doctor.cabinet}" /></td>
                <td><c:out value="${doctor.speciality}" /></td>
                <td>
                    <a href="EditDoctorFormServlet?id=<c:out value='${doctor.id}' />">Edit</a>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <a href="DeleteDoctorServlet?id=<c:out value='${doctor.id}' />">Delete</a>
                </td>
            </tr>
        </c:forEach>
    </table>
</div>
</body>
</html>