using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace wisielec
{
    abstract public class LogikaGry
    {
        protected Losowanie_Hasla losowanie_Hasla;
        protected String WylosowaneHaslo;
        protected Sprawdzanie_Hasla sprawdzanie_Hasla;
        protected Wyswietlanie_Hasla wyswietlanie_Hasla;
        protected Wyswietlanie_Wisielca wyswietlanie_Wisielca;
        
        public LogikaGry()
        {
            this.losowanie_Hasla = new Losowanie_Hasla();
            this.wyswietlanie_Wisielca = new Wyswietlanie_Wisielca();
            this.Start_Gry();
        }

        abstract protected void Start_Gry();

        public bool Czy_Litera_Byla_Podana(char litera)
        {
            return this.sprawdzanie_Hasla.Czy_Litera_Byla_Wpisana(litera);
        }

        public void Podaj_Nowa_Litere(char litera)
        {
            if (this.sprawdzanie_Hasla.Sprawdzanie_Litery(litera) == true)
            {
                this.wyswietlanie_Hasla.Zapisz_Litere(litera);
            }
            else
            {
                this.Nieprawidlowa_Litera();
            }
        }

        abstract protected void Nieprawidlowa_Litera();

        public Image Zwroc_Obrazek_Wisielca()
        {
            return this.wyswietlanie_Wisielca.Zaladuj_Obrazek();
        }

        public string Zwroc_Zakryte_Haslo()
        {
            if (this.Czy_Przegrano())
            {
                return this.wyswietlanie_Hasla.ZbudujPelneHaslo();
            }

            return this.wyswietlanie_Hasla.ZbudujZakryteHaslo();
        }

        public bool Czy_Wygrano()
        {
            return this.sprawdzanie_Hasla.Czy_Pozostaly_Litery() == false;
        }

        public bool Czy_Przegrano()
        {
            return this.wyswietlanie_Wisielca.Czy_Ostatni_Obrazek() == true;
        }

    }

    public class LogikaGry_Latwa : LogikaGry
    {
        protected override void Start_Gry()
        {
            this.WylosowaneHaslo = this.losowanie_Hasla.WylosujHaslo(7);
            this.sprawdzanie_Hasla = new Sprawdzanie_Hasla(WylosowaneHaslo);
            this.wyswietlanie_Hasla = new Wyswietlanie_Hasla(WylosowaneHaslo);

            this.Podaj_Nowa_Litere(this.Wylosuj_dodatkowa_litere());
        }

        protected override void Nieprawidlowa_Litera() 
        {
            this.wyswietlanie_Wisielca.Nastepny_Obrazek();
        }

        private char Wylosuj_dodatkowa_litere()
        {
            Random random = new Random();

            char litera = this.WylosowaneHaslo.ToCharArray()[random.Next(this.WylosowaneHaslo.Length)];

            return litera;
        }
    }

    public class LogikaGry_Normalna : LogikaGry
    {
        protected override void Start_Gry()
        {
            this.WylosowaneHaslo = this.losowanie_Hasla.WylosujHaslo(11);
            this.sprawdzanie_Hasla = new Sprawdzanie_Hasla(WylosowaneHaslo);
            this.wyswietlanie_Hasla = new Wyswietlanie_Hasla(WylosowaneHaslo);
        }

        protected override void Nieprawidlowa_Litera()
        {
            this.wyswietlanie_Wisielca.Nastepny_Obrazek();
        }
    }

    public class LogikaGry_Trudna : LogikaGry
    {
        protected override void Start_Gry()
        {
            this.WylosowaneHaslo = this.losowanie_Hasla.WylosujHaslo(80);
            this.sprawdzanie_Hasla = new Sprawdzanie_Hasla(WylosowaneHaslo);
            this.wyswietlanie_Hasla = new Wyswietlanie_Hasla(WylosowaneHaslo);
        }

        protected override void Nieprawidlowa_Litera()
        {
            this.wyswietlanie_Wisielca.Nastepny_Obrazek();
            this.wyswietlanie_Wisielca.Nastepny_Obrazek();
        }
    }
}
