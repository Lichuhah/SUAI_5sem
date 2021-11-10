<%@ page language="java" contentType="text/html; charset=UTF-8"
         pageEncoding="UTF-8"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<html xmlns:th="http://www.thymeleaf.org">
<head>
    <title>Pharmacy Application</title>
</head>
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
        <thead>
        <tr>
            <th>Name</th>
            <th>Surname</th>
            <th>Middle Name</th>
        </tr>
        </thead>
        <tbody>
            <tr th:each="patient : ${listPatient}">
                <td th:text="${patient.name}" /></td>
                <td th:text="${patient.surname}" /></td>
                <td th:text="${patient.midname}" /></td>
                <td>
                    <a th:href="EditPatientFormServlet?id=${patient.id}">Edit</a>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <a th:href="DeletePatientServlet?id=${patient.id}">Delete</a>
                </td>
            </tr>
        </tbody>
    </table>
</div>
</html>
