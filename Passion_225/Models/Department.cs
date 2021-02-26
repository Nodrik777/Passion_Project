using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Passion_225.Models
{
    public class Department
    {
        // I planned to use Species instead of Department
        public int DepartmentID { get; set; }

        public string DepartmentName { get; set; }

        public string DepartmentClass { get; set; }

        //A Department(Species) has many pets
        public ICollection<Department> Departments { get; set; }

        //Department(Species) has many employees
        public ICollection<Employee> Employees { get; set; }

    }

    public class DepartmentDto
    {
        public int DepartmentID { get; set; }

      
        public string DepartmentName { get; set; }

       

        public string DepartmentClass { get; set; }
    }
}