using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Passion_225.Models.ViewModels
{
    public class ShowDepartment
    {
        //Information about the department
        public DepartmentDto department { get; set; }

        //Information about all pets on that department
        public IEnumerable<PetDto> departmentpets { get; set; }

        //Information about all employees for that department
        public IEnumerable<EmployeeDto> departmentemployees { get; set; }
    }
}