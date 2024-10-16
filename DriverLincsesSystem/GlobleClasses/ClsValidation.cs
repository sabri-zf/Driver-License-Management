using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DriverLincsesSystem.GlobleClasses
{
    public class ClsValidation
    {


        public static bool ValidationEmail(string email)
        {
            const string Pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            Regex regex = new Regex(Pattern);

            return  regex.IsMatch(email);
        }

       public static bool ValidateStringIsEmpty(string str)
        {
            return (string.IsNullOrEmpty(str));
        }

        public static bool IsNumber(string str)
        {
            const string Pattern = @"^(0|[1-9][0-9]{0,2}(,[0-9]{3})*)$";

            Regex regex = new Regex(Pattern);

            return regex.IsMatch(str);
        }

    }
}
