namespace Picerija_Atos
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxtBrojKartice = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtGrad = new System.Windows.Forms.TextBox();
            this.txtImePrezime = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbKreditnaKartica = new System.Windows.Forms.RadioButton();
            this.rbGotovinski = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbKucnaDostava = new System.Windows.Forms.RadioButton();
            this.rbLicnoPreuzimanje = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbMala = new System.Windows.Forms.RadioButton();
            this.rbSrednja = new System.Windows.Forms.RadioButton();
            this.rbVelika = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbMorskiPlodovi = new System.Windows.Forms.CheckBox();
            this.cbOrigano = new System.Windows.Forms.CheckBox();
            this.cbJaje = new System.Windows.Forms.CheckBox();
            this.cbMasline = new System.Windows.Forms.CheckBox();
            this.cbPavlaka = new System.Windows.Forms.CheckBox();
            this.cbMajonez = new System.Windows.Forms.CheckBox();
            this.cbKecap = new System.Windows.Forms.CheckBox();
            this.cbIzaberiPicu = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnRacun = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnIsprazni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.Dodaj = new System.Windows.Forms.ListBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtPrezimeRadnika = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtImeRadnika = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(410, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Narucivanje";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.mtxtBrojKartice);
            this.groupBox1.Controls.Add(this.mtxtTelefon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAdresa);
            this.groupBox1.Controls.Add(this.txtGrad);
            this.groupBox1.Controls.Add(this.txtImePrezime);
            this.groupBox1.Location = new System.Drawing.Point(266, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 203);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Licni podaci:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Broj kartice:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Broj telefona:";
            // 
            // mtxtBrojKartice
            // 
            this.mtxtBrojKartice.Enabled = false;
            this.mtxtBrojKartice.Location = new System.Drawing.Point(140, 156);
            this.mtxtBrojKartice.Mask = "0000-0000-0000-0000";
            this.mtxtBrojKartice.Name = "mtxtBrojKartice";
            this.mtxtBrojKartice.Size = new System.Drawing.Size(229, 27);
            this.mtxtBrojKartice.TabIndex = 7;
            this.mtxtBrojKartice.Click += new System.EventHandler(this.maskedTextBox2_Click);
            // 
            // mtxtTelefon
            // 
            this.mtxtTelefon.Location = new System.Drawing.Point(140, 122);
            this.mtxtTelefon.Mask = "(999) 000-0000";
            this.mtxtTelefon.Name = "mtxtTelefon";
            this.mtxtTelefon.Size = new System.Drawing.Size(229, 27);
            this.mtxtTelefon.TabIndex = 6;
            this.mtxtTelefon.Click += new System.EventHandler(this.maskedTextBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Adresa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Grad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ime i prezime:";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(140, 88);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(229, 27);
            this.txtAdresa.TabIndex = 2;
            // 
            // txtGrad
            // 
            this.txtGrad.Location = new System.Drawing.Point(140, 55);
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.Size = new System.Drawing.Size(229, 27);
            this.txtGrad.TabIndex = 1;
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Location = new System.Drawing.Point(140, 21);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.Size = new System.Drawing.Size(229, 27);
            this.txtImePrezime.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.cbIzaberiPicu);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(266, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 380);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Narucivanje:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rbKreditnaKartica);
            this.groupBox6.Controls.Add(this.rbGotovinski);
            this.groupBox6.Location = new System.Drawing.Point(14, 293);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(355, 71);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Nacin placanja:";
            // 
            // rbKreditnaKartica
            // 
            this.rbKreditnaKartica.AutoSize = true;
            this.rbKreditnaKartica.Location = new System.Drawing.Point(185, 26);
            this.rbKreditnaKartica.Name = "rbKreditnaKartica";
            this.rbKreditnaKartica.Size = new System.Drawing.Size(162, 23);
            this.rbKreditnaKartica.TabIndex = 1;
            this.rbKreditnaKartica.TabStop = true;
            this.rbKreditnaKartica.Text = "Kreditnom karticom";
            this.rbKreditnaKartica.UseVisualStyleBackColor = true;
            this.rbKreditnaKartica.CheckedChanged += new System.EventHandler(this.rbKartica_CheckedChanged);
            // 
            // rbGotovinski
            // 
            this.rbGotovinski.AutoSize = true;
            this.rbGotovinski.Location = new System.Drawing.Point(16, 26);
            this.rbGotovinski.Name = "rbGotovinski";
            this.rbGotovinski.Size = new System.Drawing.Size(163, 23);
            this.rbGotovinski.TabIndex = 0;
            this.rbGotovinski.TabStop = true;
            this.rbGotovinski.Text = "Gotovinsko placanje";
            this.rbGotovinski.UseVisualStyleBackColor = true;
            this.rbGotovinski.CheckedChanged += new System.EventHandler(this.rbGotovinski_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbKucnaDostava);
            this.groupBox5.Controls.Add(this.rbLicnoPreuzimanje);
            this.groupBox5.Location = new System.Drawing.Point(188, 198);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(181, 89);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dostava:";
            // 
            // rbKucnaDostava
            // 
            this.rbKucnaDostava.AutoSize = true;
            this.rbKucnaDostava.Location = new System.Drawing.Point(7, 55);
            this.rbKucnaDostava.Name = "rbKucnaDostava";
            this.rbKucnaDostava.Size = new System.Drawing.Size(124, 23);
            this.rbKucnaDostava.TabIndex = 4;
            this.rbKucnaDostava.TabStop = true;
            this.rbKucnaDostava.Text = "Kucna dostava";
            this.rbKucnaDostava.UseVisualStyleBackColor = true;
            // 
            // rbLicnoPreuzimanje
            // 
            this.rbLicnoPreuzimanje.AutoSize = true;
            this.rbLicnoPreuzimanje.Location = new System.Drawing.Point(6, 26);
            this.rbLicnoPreuzimanje.Name = "rbLicnoPreuzimanje";
            this.rbLicnoPreuzimanje.Size = new System.Drawing.Size(148, 23);
            this.rbLicnoPreuzimanje.TabIndex = 3;
            this.rbLicnoPreuzimanje.TabStop = true;
            this.rbLicnoPreuzimanje.Text = "Licno preuzimanje";
            this.rbLicnoPreuzimanje.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbMala);
            this.groupBox4.Controls.Add(this.rbSrednja);
            this.groupBox4.Controls.Add(this.rbVelika);
            this.groupBox4.Location = new System.Drawing.Point(188, 57);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(181, 135);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Velicina:";
            // 
            // rbMala
            // 
            this.rbMala.AutoSize = true;
            this.rbMala.Location = new System.Drawing.Point(6, 26);
            this.rbMala.Name = "rbMala";
            this.rbMala.Size = new System.Drawing.Size(60, 23);
            this.rbMala.TabIndex = 0;
            this.rbMala.TabStop = true;
            this.rbMala.Text = "Mala";
            this.rbMala.UseVisualStyleBackColor = true;
            // 
            // rbSrednja
            // 
            this.rbSrednja.AutoSize = true;
            this.rbSrednja.Location = new System.Drawing.Point(6, 55);
            this.rbSrednja.Name = "rbSrednja";
            this.rbSrednja.Size = new System.Drawing.Size(78, 23);
            this.rbSrednja.TabIndex = 1;
            this.rbSrednja.TabStop = true;
            this.rbSrednja.Text = "Srednja";
            this.rbSrednja.UseVisualStyleBackColor = true;
            // 
            // rbVelika
            // 
            this.rbVelika.AutoSize = true;
            this.rbVelika.Location = new System.Drawing.Point(7, 85);
            this.rbVelika.Name = "rbVelika";
            this.rbVelika.Size = new System.Drawing.Size(68, 23);
            this.rbVelika.TabIndex = 2;
            this.rbVelika.TabStop = true;
            this.rbVelika.Text = "Velika";
            this.rbVelika.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbMorskiPlodovi);
            this.groupBox3.Controls.Add(this.cbOrigano);
            this.groupBox3.Controls.Add(this.cbJaje);
            this.groupBox3.Controls.Add(this.cbMasline);
            this.groupBox3.Controls.Add(this.cbPavlaka);
            this.groupBox3.Controls.Add(this.cbMajonez);
            this.groupBox3.Controls.Add(this.cbKecap);
            this.groupBox3.Location = new System.Drawing.Point(10, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(172, 237);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Besplatni prilozi:";
            // 
            // cbMorskiPlodovi
            // 
            this.cbMorskiPlodovi.AutoSize = true;
            this.cbMorskiPlodovi.Location = new System.Drawing.Point(7, 206);
            this.cbMorskiPlodovi.Name = "cbMorskiPlodovi";
            this.cbMorskiPlodovi.Size = new System.Drawing.Size(127, 23);
            this.cbMorskiPlodovi.TabIndex = 6;
            this.cbMorskiPlodovi.Text = "Morski plodovi";
            this.cbMorskiPlodovi.UseVisualStyleBackColor = true;
            // 
            // cbOrigano
            // 
            this.cbOrigano.AutoSize = true;
            this.cbOrigano.Location = new System.Drawing.Point(7, 177);
            this.cbOrigano.Name = "cbOrigano";
            this.cbOrigano.Size = new System.Drawing.Size(83, 23);
            this.cbOrigano.TabIndex = 5;
            this.cbOrigano.Text = "Origano";
            this.cbOrigano.UseVisualStyleBackColor = true;
            // 
            // cbJaje
            // 
            this.cbJaje.AutoSize = true;
            this.cbJaje.Location = new System.Drawing.Point(7, 147);
            this.cbJaje.Name = "cbJaje";
            this.cbJaje.Size = new System.Drawing.Size(54, 23);
            this.cbJaje.TabIndex = 4;
            this.cbJaje.Text = "Jaje";
            this.cbJaje.UseVisualStyleBackColor = true;
            // 
            // cbMasline
            // 
            this.cbMasline.AutoSize = true;
            this.cbMasline.Location = new System.Drawing.Point(7, 117);
            this.cbMasline.Name = "cbMasline";
            this.cbMasline.Size = new System.Drawing.Size(79, 23);
            this.cbMasline.TabIndex = 3;
            this.cbMasline.Text = "Masline";
            this.cbMasline.UseVisualStyleBackColor = true;
            // 
            // cbPavlaka
            // 
            this.cbPavlaka.AutoSize = true;
            this.cbPavlaka.Location = new System.Drawing.Point(7, 87);
            this.cbPavlaka.Name = "cbPavlaka";
            this.cbPavlaka.Size = new System.Drawing.Size(80, 23);
            this.cbPavlaka.TabIndex = 2;
            this.cbPavlaka.Text = "Pavlaka";
            this.cbPavlaka.UseVisualStyleBackColor = true;
            // 
            // cbMajonez
            // 
            this.cbMajonez.AutoSize = true;
            this.cbMajonez.Location = new System.Drawing.Point(7, 57);
            this.cbMajonez.Name = "cbMajonez";
            this.cbMajonez.Size = new System.Drawing.Size(85, 23);
            this.cbMajonez.TabIndex = 1;
            this.cbMajonez.Text = "Majonez";
            this.cbMajonez.UseVisualStyleBackColor = true;
            // 
            // cbKecap
            // 
            this.cbKecap.AutoSize = true;
            this.cbKecap.Location = new System.Drawing.Point(7, 27);
            this.cbKecap.Name = "cbKecap";
            this.cbKecap.Size = new System.Drawing.Size(70, 23);
            this.cbKecap.TabIndex = 0;
            this.cbKecap.Text = "Kecap";
            this.cbKecap.UseVisualStyleBackColor = true;
            // 
            // cbIzaberiPicu
            // 
            this.cbIzaberiPicu.FormattingEnabled = true;
            this.cbIzaberiPicu.Location = new System.Drawing.Point(115, 24);
            this.cbIzaberiPicu.Name = "cbIzaberiPicu";
            this.cbIzaberiPicu.Size = new System.Drawing.Size(254, 27);
            this.cbIzaberiPicu.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Izaberi picu:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnRacun);
            this.groupBox7.Controls.Add(this.btnNazad);
            this.groupBox7.Controls.Add(this.btnIsprazni);
            this.groupBox7.Controls.Add(this.btnDodaj);
            this.groupBox7.Controls.Add(this.Dodaj);
            this.groupBox7.Location = new System.Drawing.Point(662, 108);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(274, 488);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Narucili ste:";
            // 
            // btnRacun
            // 
            this.btnRacun.Location = new System.Drawing.Point(161, 446);
            this.btnRacun.Name = "btnRacun";
            this.btnRacun.Size = new System.Drawing.Size(107, 36);
            this.btnRacun.TabIndex = 4;
            this.btnRacun.Text = "Racun";
            this.btnRacun.UseVisualStyleBackColor = true;
            this.btnRacun.Visible = false;
            this.btnRacun.Click += new System.EventHandler(this.btnRacun_Click);
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(161, 407);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(107, 36);
            this.btnNazad.TabIndex = 3;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // btnIsprazni
            // 
            this.btnIsprazni.Location = new System.Drawing.Point(6, 444);
            this.btnIsprazni.Name = "btnIsprazni";
            this.btnIsprazni.Size = new System.Drawing.Size(107, 35);
            this.btnIsprazni.TabIndex = 2;
            this.btnIsprazni.Text = "Isprazni";
            this.btnIsprazni.UseVisualStyleBackColor = true;
            this.btnIsprazni.Visible = false;
            this.btnIsprazni.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(7, 406);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(107, 36);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // Dodaj
            // 
            this.Dodaj.FormattingEnabled = true;
            this.Dodaj.ItemHeight = 19;
            this.Dodaj.Location = new System.Drawing.Point(7, 27);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(261, 365);
            this.Dodaj.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtPrezimeRadnika);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.txtImeRadnika);
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Location = new System.Drawing.Point(662, 610);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(274, 87);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Radnik";
            // 
            // txtPrezimeRadnika
            // 
            this.txtPrezimeRadnika.Location = new System.Drawing.Point(135, 54);
            this.txtPrezimeRadnika.Name = "txtPrezimeRadnika";
            this.txtPrezimeRadnika.Size = new System.Drawing.Size(133, 27);
            this.txtPrezimeRadnika.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(131, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "Unesite prezime:";
            // 
            // txtImeRadnika
            // 
            this.txtImeRadnika.Location = new System.Drawing.Point(6, 54);
            this.txtImeRadnika.Name = "txtImeRadnika";
            this.txtImeRadnika.Size = new System.Drawing.Size(123, 27);
            this.txtImeRadnika.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Unesite ime:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Picerija_Atos.Properties.Resources.Slika3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(949, 710);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Picerija Atos - Narucivanje";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtxtBrojKartice;
        private System.Windows.Forms.MaskedTextBox mtxtTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtGrad;
        private System.Windows.Forms.TextBox txtImePrezime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rbKreditnaKartica;
        private System.Windows.Forms.RadioButton rbGotovinski;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbKucnaDostava;
        private System.Windows.Forms.RadioButton rbLicnoPreuzimanje;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbMala;
        private System.Windows.Forms.RadioButton rbSrednja;
        private System.Windows.Forms.RadioButton rbVelika;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbMorskiPlodovi;
        private System.Windows.Forms.CheckBox cbOrigano;
        private System.Windows.Forms.CheckBox cbJaje;
        private System.Windows.Forms.CheckBox cbMasline;
        private System.Windows.Forms.CheckBox cbPavlaka;
        private System.Windows.Forms.CheckBox cbMajonez;
        private System.Windows.Forms.CheckBox cbKecap;
        private System.Windows.Forms.ComboBox cbIzaberiPicu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnRacun;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Button btnIsprazni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListBox Dodaj;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtPrezimeRadnika;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtImeRadnika;
        private System.Windows.Forms.Label label8;

    }
}