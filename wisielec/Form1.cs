namespace wisielec
{
    public partial class Form1 : Form
    {
        private LogikaGry logika_gry;

        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Rozpocznij_Gre_Click(object sender, EventArgs e)
        {
            this.Zmien_Przyciski_Gdy_Start_Gry();
            this.Informacje_o_Grze.Text = "Rozpoczęto grę";

            if (latwy_button.Checked)
            {
                this.logika_gry = new LogikaGry_Latwa();
            }
            else if (normalny_button.Checked)
            {
                this.logika_gry = new LogikaGry_Normalna();
            }
            else if (trudny_button.Checked)
            {
                this.logika_gry = new LogikaGry_Trudna();
            }

            this.obrazek_wisielca.Image = this.logika_gry.Zwroc_Obrazek_Wisielca();
            this.haslo.Text = this.logika_gry.Zwroc_Zakryte_Haslo();
        }

        private void Sprawdz_Litere_Click(object sender, EventArgs e)
        {
            this.Informacje_o_Grze.Text = "";

            if (this.litera_tekst.Text == "")
            {
                return;
            }

            char litera = Char.ToLower(this.litera_tekst.Text.ToCharArray()[0]);

            if (this.logika_gry.Czy_Litera_Byla_Podana(litera))
            {
                this.Informacje_o_Grze.Text = "Wpisywałeś już tą literę";
                return;
            }

            this.logika_gry.Podaj_Nowa_Litere(litera);

            this.obrazek_wisielca.Image = this.logika_gry.Zwroc_Obrazek_Wisielca();
            this.haslo.Text = this.logika_gry.Zwroc_Zakryte_Haslo();

            if (this.logika_gry.Czy_Przegrano())
            {
                this.Informacje_o_Grze.Text = "Przegrałeś!";
                this.Zmien_Przyciski_Gdy_Koniec_Gry();
            }
            if (this.logika_gry.Czy_Wygrano())
            {
                this.Informacje_o_Grze.Text = "Wygrałeś!";
                this.Zmien_Przyciski_Gdy_Koniec_Gry();
            }
        }

        private void Zakoncz_Gre_Click(object sender, EventArgs e)
        {
            this.Zmien_Przyciski_Gdy_Koniec_Gry();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Zmien_Przyciski_Gdy_Start_Gry()
        {
            this.Sprawdz_Litere.Enabled = true;
            this.litera_tekst.Enabled = true;
            this.Rozpocznij_Gre.Enabled = false;
            this.Zakoncz_Gre.Enabled = true;
            this.latwy_button.Enabled = false;
            this.normalny_button.Enabled = false;
            this.trudny_button.Enabled = false;
        }

        private void Zmien_Przyciski_Gdy_Koniec_Gry()
        {
            this.Sprawdz_Litere.Enabled = false;
            this.litera_tekst.Enabled = false;
            this.Rozpocznij_Gre.Enabled = true;
            this.Zakoncz_Gre.Enabled = false;
            this.latwy_button.Enabled = true;
            this.normalny_button.Enabled = true;
            this.trudny_button.Enabled = true;
        }
    }
}