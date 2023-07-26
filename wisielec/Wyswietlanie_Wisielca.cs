using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wisielec
{
    public class Wyswietlanie_Wisielca
    {
        Image aktualny_obrazek;
        int aktualny_numer_obrazka;

        public Wyswietlanie_Wisielca()
        {
            aktualny_numer_obrazka = 0;
        }
        
        public Image Zaladuj_Obrazek()
        {
            this.aktualny_obrazek = Image.FromFile("../../../obrazki/" + this.aktualny_numer_obrazka + ".png");
            return aktualny_obrazek;
        }
        
        public void Nastepny_Obrazek()
        {
            aktualny_numer_obrazka += 1;
        }

        public bool Czy_Ostatni_Obrazek()
        {
            if(aktualny_numer_obrazka >= 10)
            {
                return true;
            }
            else
            {
                return false;   
            }
        }

    }   
}
