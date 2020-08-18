﻿using Caliburn.Micro;
using CaliburnTreeView.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaliburnTreeView.ViewModels
{
    public class EmployeeViewModel : Screen
    {


        private List<EmployeeType> empTyps;

        public List<EmployeeType> EmpTypes
        {
            get { return empTyps; }
            set { empTyps = value;
                NotifyOfPropertyChange(() => EmpTypes);
            }
        }


        public EmployeeViewModel()
		{
            EmployeeType type;
            Employee emp;
            Employee managed;
            Office office;
            EmpTypes = new List<EmployeeType>();

            type = new EmployeeType("Manager");
            emp = new Employee("Michael");
            managed = new Employee("John");
            emp.ManagedEmployees.Add(managed);
            managed = new Employee("Tim");
            emp.ManagedEmployees.Add(managed);
            office = new Office("Florida");
            emp.ManagedOffices.Add(office);
            office = new Office("New York");
            emp.ManagedOffices.Add(office);
            type.Employees.Add(emp);

            emp = new Employee("Paul");
            managed = new Employee("Michael");
            emp.ManagedEmployees.Add(managed);
            managed = new Employee("Cindy");
            emp.ManagedEmployees.Add(managed);
            office = new Office("California");
            emp.ManagedOffices.Add(office);
            office = new Office("Arizona");
            emp.ManagedOffices.Add(office);
            type.Employees.Add(emp);
            EmpTypes.Add(type);

            type = new EmployeeType("Project Managers");
            type.Employees.Add(new Employee("Tim"));
            type.Employees.Add(new Employee("John"));
            type.Employees.Add(new Employee("David"));
            EmpTypes.Add(type);
        }
	}
}
