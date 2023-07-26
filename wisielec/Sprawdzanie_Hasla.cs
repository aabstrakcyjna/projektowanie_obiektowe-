using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wisielec
{
    public class Sprawdzanie_Hasla
    {
        string Wylosowane_Haslo;
        HashSet<char> Litery;
        HashSet<char> Pozostale_Litery;
        HashSet<char> Wpisane_Litery;

        public Sprawdzanie_Hasla(string Wylosowane_Haslo)
        {
            this.Wylosowane_Haslo = Wylosowane_Haslo;

            this.Litery = new HashSet<char>();  
          
            
            foreach (char litera in Wylosowane_Haslo)
            {
                this.Litery.Add(litera);
            }

            this.Pozostale_Litery = new HashSet<char>(this.Litery);
            this.Wpisane_Litery = new HashSet<char>();
        }
        
        public bool Sprawdzanie_Litery(char Litera)
        {
            this.Wpisane_Litery.Add(Litera);
            if (Litery.Contains(Litera))
            {
                this.Pozostale_Litery.Remove(Litera);
                return true;
            }
            else 
            { 
                return false; 
            }
        }

        public bool Czy_Pozostaly_Litery()
        {
            return this.Pozostale_Litery.Count > 0;
        }
        
        public bool Czy_Litera_Byla_Wpisana(char Litera)
        {
            return this.Wpisane_Litery.Contains(Litera);
        }
    }
}
