using Archery.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Archery.Areas.BackOffice.Models
{
    public class AuthenticationLoginViewModels
    {
        [Required(ErrorMessage = "Le champ {0} ets obligatoire.")]       
        public string Mail { get; set; }
        [Required(ErrorMessage = "Le champ {0} ets obligatoire.")]
        public string Password { get; set; }
    }
}