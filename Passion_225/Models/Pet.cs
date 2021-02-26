using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Passion_225.Models
{
    public class Pet
    {
        [Key]
        public int PetID { get; set; }

        public string PetName { get; set; }

        public string PetType { get; set; }

        public int PetAge { get; set; }

        public decimal PetWeight { get; set; }

        public bool PetHasPic { get; set; }

        public string PicExtension { get; set; }


        [ForeignKey("Department")]
        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }

    }

    public class PetDto
    {
        public int PetID { get; set; }

        
        public string PetName { get; set; }

        
        public string PetType { get; set; }

        public int PetAge { get; set; }

        public decimal PetWeight { get; set; }

        public bool PetHasPic { get; set; }

        public string PicExtension { get; set; }

        public int DepartmentID { get; set; }
    }
}