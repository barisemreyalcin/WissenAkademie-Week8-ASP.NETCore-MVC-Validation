using System.ComponentModel.DataAnnotations;

namespace ValidationApp.Models.Validation
{
    public class IdentificationNumberValidation : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            int oddSum = 0, evenSum = 0, sum = 0;

            if (value == null) return false;

            string id = value.ToString();

            // has to be 11 characters
            if(id.Length != 11) return false;

            // cannot start with 0
            if (id[0] == '0') return false;

            // all characters have to be digit
            for (int i = 0; i < id.Length; i++)
            {
                if (!char.IsDigit(id[i])) return false;
            }

            // İlk 10 karakter toplamının 10'a bölümü son karakteri vermeli
            //int[] identificationNum = new int[11];
            //for (int i = 0; i < 11; i++)
            //{
            //    identificationNum[i] = int.Parse(id[i].ToString());
            //}

            ////char[] identificationNum = id.ToCharArray();

            //int tenthDigit = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    tenthDigit += identificationNum[i];
            //}

            //if(tenthDigit % 10 != identificationNum[10]) return false;

            return true;

            //return base.IsValid(value);
        }
    }
}
