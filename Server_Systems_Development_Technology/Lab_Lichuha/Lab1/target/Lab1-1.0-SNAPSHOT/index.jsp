<%@ page contentType="text/html; charset=UTF-8" pageEncoding="UTF-8" %>
<!DOCTYPE html>
<html>
<head>
    <title>Pharmacy Application</title>
</head>
<body>
<center>
    <h1><%= "Поликлиника имени плохого кода" %></h1>
    <h2>
    </h2>
    <table border="1" cellpadding="5">
        <caption>
            <h2>
                Main Menu
            </h2>
        </caption>
        <tr>
            <td>
                <a href="AllAppointmentServlet">Записи к врачу</a>
            </td>
            <td>
                <a href="AllDoctorServlet">Врачи</a>
            </td>
            <td>
                <a href="AllPatientServlet">Пациенты</a>
            </td>
        </tr>
    </table>
</center>
</body>
