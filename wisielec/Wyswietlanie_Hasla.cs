using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wisielec
{
    public class Wyswietlanie_Hasla
    {
        string Wylosowane_Haslo;
        HashSet<char> Odgadniete_Litery;

        public Wyswietlanie_Hasla(string Wylosowane_Haslo)
        {
            this.Wylosowane_Haslo = Wylosowane_Haslo;
            this.Odgadniete_Litery = new HashSet<char>();
        }

        public void Zapisz_Litere(char odgadnieta_litera) 
        {
            Odgadniete_Litery.Add(Char.ToLower(odgadnieta_litera));
        }

        public string ZbudujZakryteHaslo()
        {
            string Haslo_do_Wyswietlenia = "";
            foreach (char litera in Wylosowane_Haslo)
            {
                if (Odgadniete_Litery.Contains(litera))
                {
                    Haslo_do_Wyswietlenia += litera;
                }
                else
                {
                    Haslo_do_Wyswietlenia += "_";
                }
                Haslo_do_Wyswietlenia += " ";
            }
            return Haslo_do_Wyswietlenia;
        }

        public string ZbudujPelneHaslo()
        {
            string Haslo_do_Wyswietlenia = "";
            foreach (char litera in Wylosowane_Haslo)
            {
                Haslo_do_Wyswietlenia += litera + " ";
            }
            return Haslo_do_Wyswietlenia;
        }
    }
}
 