using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectCriptografie
{
    class Caesar
    {
        static Random r = new Random();
        public static int key = 3;
        public static string Criptare(string s)
        {
            s = s.ToLower();
            string sol = "";
            for (int i = 0; i < s.Length; i++)
                if (Char.IsLetter(s[i]))
                    if (s[i] <= 'z' - (char)key)
                        sol += (char)((int)s[i] + key);
                    else
                        sol += (char)((int)s[i] + key - 26);
                else
                    sol += s[i];
            return sol;
        }
        public static string Decriptare(string s)
        {
            s = s.ToLower();
            string sol = "";
            for (int i = 0; i < s.Length; i++)
                if (Char.IsLetter(s[i]))
                    if (s[i] >= 'a' + (char)key)
                        sol += (char)((int)s[i] - key);
                    else
                        sol += (char)((int)s[i] - key + 26);
                else
                    sol += s[i];

            return sol;
        }
    }
}
