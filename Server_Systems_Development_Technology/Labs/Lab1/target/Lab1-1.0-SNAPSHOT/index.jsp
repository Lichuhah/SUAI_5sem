<%@ page contentType="text/html; charset=UTF-8" pageEncoding="UTF-8" %>
<!DOCTYPE html>
<html>
<head>
    <title>JSP - Hello World</title>
</head>
<body>
<h1><%= "Поликлиника имени плохого кода" %>
</h1>
<br/>
<a href="AppointmentServlet">Записи к врачу</a>
<a href="DoctorsServlet/list">Врачи</a>
<a href="PatientsServlet/list">Пациенты</a>
</body>
</html>