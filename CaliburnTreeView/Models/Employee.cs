using System;
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
            //ManagedOffices = new List<Office>();
        }

        public string Name { get; set; }
        public List<Employee> ManagedEmployees { get; set; }
       // public List<Office> ManagedOffices { get; set; }
    }

   public class Office
    {
        public Office(string name)
        {
            Name = name;
            Cities = new List<OfficeCity>();
        }

        public string Name { get; set; }
        public List<OfficeCity> Cities { get; set; }
    }

    public class OfficeCity
    {
        public OfficeCity(string city)
        {
            City = city;
        }

        public string City { get; set; }
    }
}
