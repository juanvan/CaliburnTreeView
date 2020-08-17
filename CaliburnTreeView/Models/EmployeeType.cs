using System;
using System.Collections.Generic;
using System.Text;

namespace CaliburnTreeView.Models
{
    public class EmployeeType
    {
        public EmployeeType(string empType)
        {
            EmpType = empType;
            Employees = new List<Employee>();
        }

        public string EmpType { get; set; }
        public List<Employee> Employees { get; set; }
    }

    public class EmployeeTypes : List<EmployeeType>
    {
        public EmployeeTypes()
        {
            EmployeeType type;
            Employee emp;
            Employee managed;

            type = new EmployeeType("Manager");
            emp = new Employee("Michael");
            managed = new Employee("John");
            emp.ManagedEmployees.Add(managed);
            managed = new Employee("Tim");
            emp.ManagedEmployees.Add(managed);
            type.Employees.Add(emp);

            emp = new Employee("Paul");
            managed = new Employee("Michael");
            emp.ManagedEmployees.Add(managed);
            managed = new Employee("Cindy");
            emp.ManagedEmployees.Add(managed);
            type.Employees.Add(emp);
            this.Add(type);

            type = new EmployeeType("Project Managers");
            type.Employees.Add(new Employee("Tim"));
            type.Employees.Add(new Employee("John"));
            type.Employees.Add(new Employee("David"));
            this.Add(type);
        }
    }
}
