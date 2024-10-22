using System.ComponentModel.DataAnnotations;

namespace ValidationApp.Models.Validation
{
    public class EmailValidation : ValidationAttribute // ValidationAttribute biz ekledik
    {
        // Burayı yazdıktan sonra EmailValidation'ın using'i ekledik SystemUser'da
        // email değeri buraya geliyor
        public override bool IsValid(object? value)
        {
            string dataToCheck = string.Empty;
            if (value == null) return false;

            dataToCheck = value.ToString();

            if (dataToCheck.Where(x => x == ' ').ToList().Count() > 0) return false;

            if(dataToCheck.Split('@').Count() > 2) return false;

            if(dataToCheck.EndsWith("@contoso.com")) return true;

            return false;
            //return base.IsValid(value); 
        }
    }
}
