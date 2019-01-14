using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectCriptografie
{
    class Rot13
    {
        static Random r = new Random();
        public static string Criptare(string s)
        {
            s = s.ToLower();
            string sol = "";
            for (int i = 0; i < s.Length; i++)
                if (Char.IsLetter(s[i]))
                    if (s[i] <= 'z' - (char)13)
                        sol += (char)((int)s[i] + 13);
                    else
                        sol += (char)((int)s[i] - 13);
                else
                    sol += s[i];
            return sol;
        }
    }
}
