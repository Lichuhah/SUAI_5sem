package com.example.lab3.dao;

import com.example.lab3.model.Employee;
import com.example.lab3.model.EmployeeForm;
import org.springframework.stereotype.Repository;

import java.util.*;

@Repository
public class EmployeeDAO {

    private static final Map<Long, Employee> empMap = new HashMap<Long, Employee>();

    static {
        initEmps();
    }

    private static void initEmps() {
        Employee emp1 = new Employee(1L, "Иван", "Иванов", "Уборщик","1");
        Employee emp2 = new Employee(2L, "Олег", "Петров", "Бухгалтер","2");
        Employee emp3 = new Employee(3L, "Петр", "Моржов", "Ген.Директор","3");

        empMap.put(emp1.getEmpId(), emp1);
        empMap.put(emp2.getEmpId(), emp2);
        empMap.put(emp3.getEmpId(), emp3);
    }

    public Long getMaxEmpId() {
        Set<Long> keys = empMap.keySet();
        Long max = 0L;
        for (Long key : keys) {
            if (key > max) {
                max = key;
            }
        }
        return max;
    }

    public Employee getEmployee(Long empId) {
        return empMap.get(empId);
    }

    public Employee addEmployee(EmployeeForm empForm) {
        Long empId= this.getMaxEmpId()+ 1;
        empForm.setEmpId(empId);
        Employee newEmp = new Employee(empForm);

        empMap.put(newEmp.getEmpId(), newEmp);
        return newEmp;
    }

    public Employee updateEmployee(EmployeeForm empForm) {
        Employee emp = this.getEmployee(empForm.getEmpId());
        if(emp!= null)  {
            emp.setEmpName(empForm.getEmpName());
            emp.setEmpSurname(empForm.getEmpSurname());
            emp.setPosition(empForm.getPosition());
            emp.setPriority(empForm.getPriority());
        }
        return emp;
    }

    public void deleteEmployee(Long empId) {
        empMap.remove(empId);
    }

    public List<Employee> getAllEmployees() {
        Collection<Employee> c = empMap.values();
        List<Employee> list = new ArrayList<Employee>();
        list.addAll(c);
        return list;
    }

}