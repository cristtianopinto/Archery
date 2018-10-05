﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Archery.Models
{
    public class AuthenticationUserViewModels
    {
        [Display(Name = "Login")]
        [Required(ErrorMessage = "Le champ {0} ets obligatoire.")]
        public string Mail { get; set; }
        [Display(Name = "Mot de Passe")]
        [Required(ErrorMessage = "Le champ {0} ets obligatoire.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}