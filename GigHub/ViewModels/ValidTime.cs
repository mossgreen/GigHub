using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace GigHub.ViewModels
{
    public class ValidTime: ValidationAttribute
    {

        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value), 
                "HH:MM", 
                CultureInfo.CurrentCulture, 
                DateTimeStyles.None, 
                out dateTime);

            return (isValid);
        }
    }
}