using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BusinessLayer
{
     public static class ClsValidateing
    {

       public static bool ValidtionEmail(string emailValidation)
        {
            string petter = "[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}";

            Regex regex = new Regex(petter);

            return regex.IsMatch(emailValidation);
        }

    }
}
