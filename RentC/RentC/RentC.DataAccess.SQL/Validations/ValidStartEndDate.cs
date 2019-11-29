using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentC.DataAccess.SQL.Validations
{
    class ValidStartEndDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Reservation r = new Reservation();
            DateTime startDate = Convert.ToDateTime(value);
            if (startDate.Date<r.EndDate.Date)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult
                  (startDate.Date.ToString() + "     "+ r.EndDate.Date.ToString());
            }
        }
    }
}
