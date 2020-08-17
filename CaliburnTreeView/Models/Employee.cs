﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CaliburnTreeView.Models
{
    public class Employee
    {
        public Employee(string name)
        {
            Name = name;
            ManagedEmployees = new List<Employee>();
        }

        public string Name { get; set; }
        public List<Employee> ManagedEmployees { get; set; }
    }

   
}