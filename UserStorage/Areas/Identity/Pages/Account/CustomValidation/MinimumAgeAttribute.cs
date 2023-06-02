using System;
using System.ComponentModel.DataAnnotations;

namespace UserStorage.Areas.Identity.Pages.Account.CustomValidation
{
   public class MinimumAgeAttribute : ValidationAttribute
   {
      public int MinimumAge { get; }

      public MinimumAgeAttribute(int minimumAge)
      {
         MinimumAge = minimumAge;
         ErrorMessage = "{0} must be someone at least {1} years of age";
      }

      public override string FormatErrorMessage(string name)
      {
         return string.Format(ErrorMessageString, name, MinimumAge);
      }

      public override bool IsValid(object value)
      {
         DateTime date;
         if (DateTime.TryParse(value.ToString(), out date))
         {
            return date.AddYears(MinimumAge) < DateTime.Now;
         }

         return false;
      }
   }
}
