using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Passion_225.Models.ViewModels
{
    public class UpdatePet
    {
        public PetDto pet { get; set; }
        //Needed for a dropdownlist which presents the pet 
        public IEnumerable<DepartmentDto> department { get; set; }
    }
}