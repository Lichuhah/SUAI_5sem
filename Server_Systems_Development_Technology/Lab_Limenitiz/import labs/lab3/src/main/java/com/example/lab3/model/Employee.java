package com.example.lab3.model;
public class Employee {

    private Long empId;
    private String empName;
    private String empSurname;
    private String position;
    private String priority;

    public Employee() {

    }

    public Employee(EmployeeForm empForm) {
        this.empId = empForm.getEmpId();
        this.empName = empForm.getEmpName();
        this.empSurname = empForm.getEmpSurname();
        this.position = empForm.getPosition();
        this.priority = empForm.getPriority();
    }

    public Employee(Long empId, String empName, String empSurname, String position, String priority) {
        this.empId = empId;
        this.empName = empName;
        this.empSurname = empSurname;
        this.position = position;
        this.priority = priority;
    }

    public Long getEmpId() {
        return empId;
    }

    public void setEmpId(Long empId) {
        this.empId = empId;
    }

    public String getEmpName() {
        return empName;
    }

    public void setEmpName(String empName) {
        this.empName = empName;
    }

    public String getEmpSurname() {
        return empSurname;
    }

    public void setEmpSurname(String empSurname) {
        this.empSurname = empSurname;
    }

    public String getPosition() {
        return position;
    }

    public void setPosition(String position) {
        this.position = position;
    }

    public String getPriority() {
        return priority;
    }
    public void setPriority(String priority) {
        this.priority = priority;
    }
}