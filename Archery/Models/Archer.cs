using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Archery.Models
{
    public class Archer : User
    {
        [Display(Name = "Numéro de license")]
        public string LicenseNumber { get; set; }

        /*solution julien - ele criou o atributo age no arche
        [Range(9,100,ErrorMessage = "Le Tireur doit avoir entre {1} et {2} ans")]
        public double Age{ get { return DateTime.Now.Subtract(BirthDate).TotalDays / 365; }}*/
    }
}