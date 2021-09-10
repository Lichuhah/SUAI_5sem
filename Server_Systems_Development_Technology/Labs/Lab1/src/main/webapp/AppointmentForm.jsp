<%@ page language="java" contentType="text/html; charset=UTF-8"
         pageEncoding="UTF-8"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<html>
<head>
    <title>Books Store Application</title>
</head>
<body>
<center>
    <h1>Doctor Management</h1>
    <h2>
        <a href="NewAppointmentFormServlet">Add New Book</a>
        &nbsp;&nbsp;&nbsp;
        <a href="AllAppointmentServlet">List All Books</a>

    </h2>
</center>
<div align="center">
    <select size=1 name="category" id="listdoc">
        <c:forEach items="${listdocs}" var="category">
            <option onclick="changeDoc(${category.id})" value="${category.id}">${category.name}/>
        </c:forEach>
    </select>
    <select size=1 name="category" id="listpat">
        <c:forEach items="${listpats}" var="category">
            <option  onclick="changePat(${category.id})" value="${category.id}">${category.name}"/>
        </c:forEach>
    </select>

        <form action="AddAppointmentServlet" method="post">
            <table border="1" cellpadding="5">
                <caption>
                    <h2>
                            Add New Appointment
                    </h2>
                </caption>
                <tr>
                    <th>Id Doctor: </th>
                    <td>
                        <input type="number" name="id_doctor" size="45" id="iddoc"
                        />
                    </td>
                </tr>
                <tr>
                    <th>Id Patient: </th>
                    <td>
                        <input type="number" name="id_patient" size="45" id="idpat"
                        />
                    </td>
                </tr>
                <tr>
                    <th>Info: </th>
                    <td>
                        <input type="text" name="info" size="45"
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

<script>
    function changeDoc(data){
        document.getElementById("iddoc").value = data;
    }

    function changePat(data){
        document.getElementById("idpat").value = data;
    }

</script>
