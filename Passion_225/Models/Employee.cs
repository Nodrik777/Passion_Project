using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Passion_225.Models
{
    public class Employee
    {

        [Key]
        public int EmployeeID { get; set; }

        public string EmployeeFirstName { get; set; }

        public string EmployeeLastName { get; set; }
        public DateTime HireDate { get; set; }

        public string EmployeeBio { get; set; }


        //Utilizes the inverse property to specify the "Many"
        //https://www.entityframeworktutorial.net/code-first/inverseproperty-dataannotations-attribute-in-code-first.aspx
        //One Employee can work at many departments
        public ICollection<Department> Departments { get; set; }
    }

    public class EmployeeDto
    {
        public int EmployeeID { get; set; }

        public string EmployeeFirstName { get; set; }

        public string EmployeeLastName { get; set; }
        public DateTime HireDate { get; set; }

        public string EmployeeBio { get; set; }
    }
}