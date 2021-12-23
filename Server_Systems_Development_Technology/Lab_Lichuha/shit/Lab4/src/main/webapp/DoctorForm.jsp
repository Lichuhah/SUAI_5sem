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
        <a href="NewDoctorFormServlet">Add New Doctor</a>
        &nbsp;&nbsp;&nbsp;
        <a href="AllDoctorServlet">List All Doctors</a>
        &nbsp;
        <a href="index.jsp">Main menu</a>
    </h2>
</center>
<div align="center">
    <c:if test="${doctor != null}">
    <form action="UpdateDoctorServlet" method="post">
        </c:if>
        <c:if test="${doctor == null}">
        <form action="AddDoctorServlet" method="post">
            </c:if>
            <table border="1" cellpadding="5">
                <caption>
                    <h2>
                        <c:if test="${doctor != null}">
                            Edit Doctor
                        </c:if>
                        <c:if test="${doctor == null}">
                            Add New Doctor
                        </c:if>
                    </h2>
                </caption>
                <c:if test="${doctor != null}">
                    <input type="hidden" name="id" value="<c:out value='${doctor.id}' />" />
                </c:if>
                <tr>
                    <th>Name: </th>
                    <td>
                        <input type="text" name="name" size="45"
                               value="<c:out value='${doctor.name}' />"
                        />
                    </td>
                </tr>
                <tr>
                    <th>Surname: </th>
                    <td>
                        <input type="text" name="surname" size="45"
                               value="<c:out value='${doctor.surname}' />"
                        />
                    </td>
                </tr>
                <tr>
                    <th>Middle Name: </th>
                    <td>
                        <input type="text" name="midname" size="45"
                               value="<c:out value='${doctor.midname}' />"
                        />
                    </td>
                </tr>
                <tr>
                    <th>Cabinet: </th>
                    <td>
                        <input type="number" name="cabinet" size="45"
                               value="<c:out value='${doctor.cabinet}' />"
                        />
                    </td>
                </tr>
                <tr>
                    <th>Speciality: </th>
                    <td>
                        <input type="text" name="speciality" size="45"
                               value="<c:out value='${doctor.speciality}' />"
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