using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentC.DataAccess.SQL
{
    class ValidBirthDate : ValidationAttribute
    {
        protected override ValidationResult
        IsValid(object value, ValidationContext validationContext)
        {
            DateTime _dateJoin = (DateTime)value;
            if (_dateJoin < DateTime.Now)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult
                    ("Date can not be greater than current date.");
            }
        }
    }
}
