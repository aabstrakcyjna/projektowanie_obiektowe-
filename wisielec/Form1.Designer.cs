namespace wisielec
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            Sprawdz_Litere = new Button();
            litera_tekst = new TextBox();
            Informacje_o_Grze = new Label();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            Rozpocznij_Gre = new Button();
            Zakoncz_Gre = new Button();
            haslo = new Label();
            obrazek_wisielca = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            latwy_button = new RadioButton();
            normalny_button = new RadioButton();
            trudny_button = new RadioButton();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)obrazek_wisielca).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 522F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 95F));
            tableLayoutPanel1.Controls.Add(Sprawdz_Litere, 0, 2);
            tableLayoutPanel1.Controls.Add(litera_tekst, 0, 3);
            tableLayoutPanel1.Controls.Add(Informacje_o_Grze, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 2, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 3);
            tableLayoutPanel1.Controls.Add(haslo, 1, 2);
            tableLayoutPanel1.Controls.Add(obrazek_wisielca, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 2, 3);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 88.29175F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.7082529F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            tableLayoutPanel1.Size = new Size(718, 596);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint_1;
            // 
            // Sprawdz_Litere
            // 
            Sprawdz_Litere.Enabled = false;
            Sprawdz_Litere.Location = new Point(3, 460);
            Sprawdz_Litere.Name = "Sprawdz_Litere";
            Sprawdz_Litere.Size = new Size(95, 44);
            Sprawdz_Litere.TabIndex = 0;
            Sprawdz_Litere.Text = "Sprawdź literę ";
            Sprawdz_Litere.UseVisualStyleBackColor = true;
            Sprawdz_Litere.Click += Sprawdz_Litere_Click;
            // 
            // litera_tekst
            // 
            litera_tekst.Enabled = false;
            litera_tekst.Font = new Font("Book Antiqua", 24F, FontStyle.Bold, GraphicsUnit.Point);
            litera_tekst.Location = new Point(3, 514);
            litera_tekst.MaxLength = 1;
            litera_tekst.Multiline = true;
            litera_tekst.Name = "litera_tekst";
            litera_tekst.Size = new Size(95, 76);
            litera_tekst.TabIndex = 2;
            litera_tekst.TextAlign = HorizontalAlignment.Center;
            litera_tekst.TextChanged += textBox2_TextChanged;
            // 
            // Informacje_o_Grze
            // 
            Informacje_o_Grze.Anchor = AnchorStyles.None;
            Informacje_o_Grze.AutoSize = true;
            Informacje_o_Grze.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Informacje_o_Grze.Location = new Point(362, 10);
            Informacje_o_Grze.Name = "Informacje_o_Grze";
            Informacje_o_Grze.Size = new Size(0, 30);
            Informacje_o_Grze.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(626, 496);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 3;
            label1.Text = "Poziom:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(Rozpocznij_Gre, 0, 0);
            tableLayoutPanel2.Controls.Add(Zakoncz_Gre, 1, 0);
            tableLayoutPanel2.Location = new Point(104, 514);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(516, 79);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // Rozpocznij_Gre
            // 
            Rozpocznij_Gre.Location = new Point(3, 3);
            Rozpocznij_Gre.Name = "Rozpocznij_Gre";
            Rozpocznij_Gre.Size = new Size(252, 73);
            Rozpocznij_Gre.TabIndex = 1;
            Rozpocznij_Gre.Text = "Rozpocznij grę";
            Rozpocznij_Gre.UseVisualStyleBackColor = true;
            Rozpocznij_Gre.Click += Rozpocznij_Gre_Click;
            // 
            // Zakoncz_Gre
            // 
            Zakoncz_Gre.Enabled = false;
            Zakoncz_Gre.Location = new Point(261, 3);
            Zakoncz_Gre.Name = "Zakoncz_Gre";
            Zakoncz_Gre.Size = new Size(252, 73);
            Zakoncz_Gre.TabIndex = 3;
            Zakoncz_Gre.Text = "Zakończ grę";
            Zakoncz_Gre.UseVisualStyleBackColor = true;
            Zakoncz_Gre.Click += Zakoncz_Gre_Click;
            // 
            // haslo
            // 
            haslo.Anchor = AnchorStyles.None;
            haslo.AutoSize = true;
            haslo.Font = new Font("Book Antiqua", 24F, FontStyle.Bold, GraphicsUnit.Point);
            haslo.Location = new Point(362, 464);
            haslo.Name = "haslo";
            haslo.Size = new Size(0, 39);
            haslo.TabIndex = 5;
            // 
            // obrazek_wisielca
            // 
            obrazek_wisielca.Anchor = AnchorStyles.None;
            obrazek_wisielca.Location = new Point(162, 53);
            obrazek_wisielca.Name = "obrazek_wisielca";
            obrazek_wisielca.Size = new Size(400, 400);
            obrazek_wisielca.TabIndex = 6;
            obrazek_wisielca.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(latwy_button, 0, 0);
            tableLayoutPanel3.Controls.Add(normalny_button, 0, 1);
            tableLayoutPanel3.Controls.Add(trudny_button, 0, 2);
            tableLayoutPanel3.Location = new Point(626, 514);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel3.Size = new Size(89, 79);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // latwy_button
            // 
            latwy_button.AutoSize = true;
            latwy_button.Location = new Point(3, 3);
            latwy_button.Name = "latwy_button";
            latwy_button.Size = new Size(53, 19);
            latwy_button.TabIndex = 0;
            latwy_button.Text = "łatwy";
            latwy_button.UseVisualStyleBackColor = true;
            // 
            // normalny_button
            // 
            normalny_button.AutoSize = true;
            normalny_button.Checked = true;
            normalny_button.Location = new Point(3, 28);
            normalny_button.Name = "normalny_button";
            normalny_button.Size = new Size(76, 19);
            normalny_button.TabIndex = 1;
            normalny_button.TabStop = true;
            normalny_button.Text = "normalny";
            normalny_button.UseVisualStyleBackColor = true;
            // 
            // trudny_button
            // 
            trudny_button.AutoSize = true;
            trudny_button.Location = new Point(3, 53);
            trudny_button.Name = "trudny_button";
            trudny_button.Size = new Size(60, 19);
            trudny_button.TabIndex = 2;
            trudny_button.Text = "trudny";
            trudny_button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 620);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = " ";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)obrazek_wisielca).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button Sprawdz_Litere;
        private Button Rozpocznij_Gre;
        private Button Zakoncz_Gre;
        private TextBox litera_tekst;
        private Label label1;
        private Label Informacje_o_Grze;
        private Label haslo;
        private PictureBox obrazek_wisielca;
        private TableLayoutPanel tableLayoutPanel3;
        private RadioButton latwy_button;
        private RadioButton normalny_button;
        private RadioButton trudny_button;
    }
}