<%@ page language="java" contentType="text/html; charset=UTF-8"
         pageEncoding="UTF-8"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<html>
<head>
    <title>Pharmacy Application</title>
</head>
<body>
<center>
    <h1>Patient Management</h1>
    <h2>
        <a href="NewFormServlet">Add New Book</a>
        &nbsp;&nbsp;&nbsp;
        <a href="AllPatientServlet">List All Books</a>
        &nbsp;
        <a href="index.jsp">Main menu</a>
    </h2>
</center>
<div align="center">
    <c:if test="${patient != null}">
    <form action="UpdatePatientServlet" method="post">
        </c:if>
        <c:if test="${patient == null}">
        <form action="AddPatientServlet" method="post">
            </c:if>
            <table border="1" cellpadding="5">
                <caption>
                    <h2>
                        <c:if test="${patient != null}">
                            Edit Patient
                        </c:if>
                        <c:if test="${patient == null}">
                            Add New Patient
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
                    <th>Surname: </th>
                    <td>
                        <input type="text" name="surname" size="45"
                               value="<c:out value='${patient.surname}' />"
                        />
                    </td>
                </tr>
                <tr>
                    <th>Middle name: </th>
                    <td>
                        <input type="text" name="midname" size="45"
                               value="<c:out value='${patient.midname}' />"
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