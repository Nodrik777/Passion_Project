using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Passion_225.Models.ViewModels
    {
        public class ShowPet
        {

            public PetDto Pet { get; set; }
            //information about the team the player plays for
            public DepartmentDto department { get; set; }
        }
    }
