<%@ page language="java" contentType="text/html; charset=UTF-8"
         pageEncoding="UTF-8"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<html>
<head>
    <title>Pharmacy Application</title>
</head>
<body>
<center>
    <h1>Patients Management</h1>
    <h2>
        <a href="NewPatientFormServlet">Add New Patient</a>
        &nbsp;&nbsp;&nbsp;
        <a href="AllPatientServlet">List All Patient</a>
        &nbsp;
        <a href="index.jsp">Main menu</a>
    </h2>
</center>
<div align="center">
    <table border="1" cellpadding="5">
        <caption><h2>List of Patient</h2></caption>
        <tr>
            <th>Name</th>
            <th>Surname</th>
            <th>Middle Name</th>
        </tr>
        <c:forEach var="patient" items="${listPatient}">
            <tr>
                <td><c:out value="${patient.name}" /></td>
                <td><c:out value="${patient.surname}" /></td>
                <td><c:out value="${patient.midname}" /></td>
                <td>
                    <a href="EditPatientFormServlet?id=<c:out value='${patient.id}' />">Edit</a>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <a href="DeletePatientServlet?id=<c:out value='${patient.id}' />">Delete</a>
                </td>
            </tr>
        </c:forEach>
    </table>
</div>
</body>
</html>
