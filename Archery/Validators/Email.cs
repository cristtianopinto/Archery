using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Archery.Data;
namespace Archery.Validators
{
    public class Email : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if(value !=null && value is string)
            {
                using (var db = new ArcheryDbContext())
                {
                    return !(db.Archers.Any(x => x.Mail == value.ToString()));
                }
            }
            return true;
                        
        }
    }
}