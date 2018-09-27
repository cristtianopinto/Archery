using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Archery.Validators
{
    [AttributeUsage(AttributeTargets.Property)]// por so utiliza-lo em propriedades
    public class Age : ValidationAttribute
    {        
        public int MinimumAge { get; private set; }
        public Age(int minimumAge)
        {
            this.MinimumAge = minimumAge;
        }
        public override bool IsValid(object value)
        {
            //3
            if (value is DateTime)
            {

                return (DateTime.Now.AddYears(-this.MinimumAge) >= (DateTime)value);

            }
            else
            {
                throw new ArgumentException("Le type doit être un DateTime");
            }                
           
        }
        public override string FormatErrorMessage(string name)
        {
            return string.Format(this.ErrorMessage,name,this.MinimumAge.ToString());
        }

    }
}