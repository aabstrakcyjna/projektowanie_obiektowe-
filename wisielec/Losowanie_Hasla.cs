using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wisielec
{
    public class Losowanie_Hasla
    {
        static private string[] hasla = File.ReadAllLines("../../../slowa.txt");

        public Losowanie_Hasla()
        {
        }

        public String WylosujHaslo(int maxlength)
        {
            Random random = new Random();
            string Wylosowane_haslo;
            do
            {
                Wylosowane_haslo = hasla[random.Next(hasla.Length)].Trim();
            }
            while (Wylosowane_haslo.Length>maxlength);
            return Wylosowane_haslo.ToLower();
        }
    }
}
