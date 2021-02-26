using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Passion_225.Models.ViewModels
{
    public class UpdateEmployee
    {
        //base information about the employee
        public EmployeeDto employee { get; set; }
        //display all teams that this sponsor is sponsoring
        public IEnumerable<DepartmentDto>departmentemployees {get; set; }
        //display departments which could be working in a dropdownlist
        public IEnumerable<DepartmentDto> alldepartments { get; set; }
    }
}