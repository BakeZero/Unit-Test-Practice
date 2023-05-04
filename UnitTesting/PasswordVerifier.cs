using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    internal class PasswordVerifier
    {

        public bool Verify(string pass)
        {
            int count = 0;
            bool lower = false, upper = false, num = false;
            if (pass.Length < 8)
                return false;
            if (pass == "")
                return false;

            foreach (char c in pass)
            {
                if (Char.IsLower(c) && lower == false)
                {
                    count++;
                    lower = true;
                }
                else if (Char.IsUpper(c) && upper == false)
                {
                    count++;
                    upper = true;
                }
                else if (Char.IsNumber(c) && num == false)
                {
                    count++;
                    num = true;
                }
            }
            if (lower == false)
                return false;
            else if (count >= 3)
                return true;
            else
                return false;
        }
    }
}
