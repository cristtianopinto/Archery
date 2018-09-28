using Archery.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Archery.Models
{
    public abstract class User
    {
        

        public int ID { get; set; }


        [Required(ErrorMessage = "Le champ {0} ets obligatoire.")]
        [StringLength(150,ErrorMessage ="Le champ {0} doit contenir {1} caractères max.")]
        [Display(Name = "Adresse mail")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                           @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                           @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage ="Le format n'est pas bon")]
        public string Mail { get; set; }

        
        [Required(ErrorMessage = "Le champ {0} ets obligatoire.")]
        [Display(Name = "Mot de passe")]
        [DataType(DataType.Password)] // para gerar o html helper do tipo password
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{6,}$", ErrorMessage = "{0} incorrect")]
        public string Password { get; set; }

        [NotMapped]
        [Display(Name = "Confirmation du mot de passe")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage = "La confirmation n'est pas bonne.")]
        public string ConfirmedPassword { get; set; }

        [Required(ErrorMessage = "Le champ {0} ets obligatoire.")]
        [Display(Name = "Nom")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Le champ {0} ets obligatoire.")]
        [Display(Name = "Prénom")]
        public string FirstName { get; set; }
        
        
        [Required(ErrorMessage = "Le champ {0} ets obligatoire.")]
        [Display(Name = "Date de naissance")]
        [DataType(DataType.Date)]
        [Age(10,MaximumAge = 100,ErrorMessage = "Pour le champ {0}. Vous deves avoir plus de {1} ans et moins {2}")]//3
        public DateTime BirthDate { get; set; } // ? - campo pode ser nulo


       
    }

   
}