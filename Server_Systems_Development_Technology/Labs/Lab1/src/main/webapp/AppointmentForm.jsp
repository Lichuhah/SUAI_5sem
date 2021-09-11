<%@ page language="java" contentType="text/html; charset=UTF-8"
         pageEncoding="UTF-8"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<html>
<head>
    <title>Pharmacy Application</title>
</head>
<body>
<center>
    <h1>Doctor Management</h1>
    <h2>
        <a href="NewAppointmentFormServlet">Add New Book</a>
        &nbsp;&nbsp;&nbsp;
        <a href="AllAppointmentServlet">List All Books</a>
        &nbsp;
        <a href="index.jsp">Main menu</a>
    </h2>
</center>
<div align="center">


        <form action="AddAppointmentServlet" method="post">
            <th>Врач:</th>
            <select size=1 name="id_doctor" id="iddoc" required="required">
                <c:forEach items="${listdocs}" var="category">
                    <option onclick="changeDoc(${category.id})" value="${category.id}">${category.name}</option>
                </c:forEach>
            </select>
            <th>Пациент:</th>
            <select size=1 name="id_patient" id="idpat" required="required">
                <c:forEach items="${listpats}" var="category">
                    <option  onclick="changePat(${category.id})" value="${category.id}">${category.name}</option>
                </c:forEach>
            </select>
            <table border="1" cellpadding="5">
                <caption>
                    <h2>
                            Add New Appointment
                    </h2>
                </caption>
                <tr>
                    <th>Info: </th>
                    <td>
                        <input type="text" name="info" size="45"
                        />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <input type="submit" value="Save"/>
                    </td>
                </tr>
            </table>
        </form>
</div>
</body>
</html>

<script>
        document.getElementById("iddoc").value = null;
        document.getElementById("idpat").value = null;

    function changeDoc(data){
        document.getElementById("iddoc").value = data;
    }

    function changePat(data){
        document.getElementById("idpat").value = data;
    }

</script>
