<%@ page language="java" contentType="text/html; charset=UTF-8"
         pageEncoding="UTF-8"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<html>
<head>
    <title>Patient Application</title>
</head>
<body>
<center>
    <h1>Patients Management</h1>
    <h2>
        <a href="add">Add New Patient</a>
        &nbsp;&nbsp;&nbsp;
        <a href="all">List All Patient</a>

    </h2>
</center>
<div align="center">
    <table border="1" cellpadding="5">
        <caption><h2>List of Patient</h2></caption>
        <tr>
            <th>Id</th>
            <th>Name</th>
            <th>Birthday</th>
        </tr>
        <c:forEach var="patient" items="${listPatient}">
            <tr>
                <td><c:out value="${patient.id}" /></td>
                <td><c:out value="${patient.name}" /></td>
                <td><c:out value="${patient.birthday}" /></td>
                <td>
                    <a href="edit?id=<c:out value='${patient.id}' />">Edit</a>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <a href="delete?id=<c:out value='${patient.id}' />">Delete</a>
                </td>
            </tr>
        </c:forEach>
    </table>
</div>
</body>
</html>
