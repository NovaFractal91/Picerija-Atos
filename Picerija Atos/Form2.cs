using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Picerija_Atos
{
    public partial class Form2 : Form
    {
        Form3 forma3;
        string cena;
        string naziv;
        string prilozi;
        string placanje;


        public string ImePrezime
        {
            get { return this.txtImePrezime.Text; }
        }
        public string Grad
        {
            get { return this.txtGrad.Text; }
        }
        public string Adresa
        {
            get { return this.txtAdresa.Text; }
        }
        public string Telefon
        {
            get { return this.mtxtTelefon.Text; }
        }
        public string KreditnaKartica
        {
            get { return this.mtxtBrojKartice.Text; }
        }
        public string ImeRadnika
        {
            get { return this.txtImeRadnika.Text; }
        }
        public string PrezimeRadnika
        {
            get { return this.txtPrezimeRadnika.Text; }
        }





        public string Dostava()
        {
            string dostava;
            if (rbLicnoPreuzimanje.Checked)
            {
                return dostava = "Licno preuzimanje";
            }
            else
            {
                return dostava = "Kucna dostava";
            }
        }
        public string Velicina()
        {
            string velicina;
            if (rbMala.Checked)
            {
                return velicina = "Mala";
            }
            else if (rbSrednja.Checked)
            {
                return velicina = "Srednja";
            }
            else if (rbVelika.Checked) ;
            {
                return velicina = "Velika";
            }

        }

        public static List<string> lista = new List<string>();

        public Form2()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            this.mtxtTelefon.Select(0, 0);
        }

        private void maskedTextBox2_Click(object sender, EventArgs e)
        {
            this.mtxtBrojKartice.Select(0, 0);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<string> vrstaPice = new List<string>();
            vrstaPice.Add("Margarita");
            vrstaPice.Add("Napolitana");
            vrstaPice.Add("Capriciosa");
            vrstaPice.Add("Fungi");
            vrstaPice.Add("Vesuvio");
            vrstaPice.Add("Quattro stagione");
            vrstaPice.Add("Siciliana");
            vrstaPice.Add("Italiana");
            vrstaPice.Add("Sopresa");
            vrstaPice.Add("Al tonno");
            vrstaPice.Add("Calzone");
            vrstaPice.Add("Hawaii");
            foreach (string pica in vrstaPice)
            {
                cbIzaberiPicu.Items.Add(pica);
            }
          
        }

        private void btnRacun_Click(object sender, EventArgs e)
        {
            foreach (var item in Dodaj.Items)
            {
                lista.Add(item.ToString());
            }

            DialogResult dijalog = MessageBox.Show("Da li ste popunili sva polja?", "Narucivanje", MessageBoxButtons.YesNo);
            if (dijalog == DialogResult.Yes)
            {
                Form3 forma3 = new Form3();
                forma3.imePrezime = ImePrezime;
                forma3.grad = Grad;
                forma3.adresa = Adresa;
                forma3.brojTelefona = Telefon;
                forma3.brojKartice = KreditnaKartica;
                forma3.imeRadnika = ImeRadnika;
                forma3.prezimeRadnika = PrezimeRadnika;
                this.Hide();
                forma3.Show();
            }
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            Form1 forma1 = new Form1();
            this.Hide();
            forma1.Show();
        }

        private void rbKartica_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKreditnaKartica.Checked)
            {
                mtxtBrojKartice.Enabled = true;
                MessageBox.Show("Izabrali ste placanje kreditnom karicom. U licnim podacima unesite broj kreditne kartice.", "Picerija Atos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dodaj.Items.Clear();
            btnIsprazni.Visible = false;
            btnRacun.Visible = false;
        }

        private void rbGotovinski_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGotovinski.Checked)
            {
                mtxtBrojKartice.Enabled = false;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (cbIzaberiPicu.SelectedIndex > -1)
            {
                if (rbMala.Checked)
                {
                    cena = "100 dinara";
                }
                if (rbSrednja.Checked)
                {
                    cena = "500 dinara";
                }
                if (rbVelika.Checked)
                {
                    cena = "1000 dinara";
                }
            }
            if (cbIzaberiPicu.SelectedItem == "Napolitana")
            {
                if (rbMala.Checked)
                {
                    cena = "200 dinara";
                }
                if (rbSrednja.Checked)
                {
                    cena = "600 dinara";
                }
                if (rbVelika.Checked)
                {
                    cena = "1100 dinara";
                }
            }
            if (cbIzaberiPicu.SelectedItem == "Capriciosa")
            {
                if (rbMala.Checked)
                {
                    cena = "300 dinara";
                }
                if (rbSrednja.Checked)
                {
                    cena = "700 dinara";
                }
                if (rbVelika.Checked)
                {
                    cena = "1200 dinara";
                }
            }
            if (cbIzaberiPicu.SelectedItem == "Fungi")
            {
                if (rbMala.Checked)
                {
                    cena = "400 dinara";
                }
                if (rbSrednja.Checked)
                {
                    cena = "800 dinara";
                }
                if (rbVelika.Checked)
                {
                    cena = "1300 dinara";
                }
            }
            if (cbIzaberiPicu.SelectedItem == "Vesuvio")
            {
                if (rbMala.Checked)
                {
                    cena = "dinara";
                }
                if (rbSrednja.Checked)
                {
                    cena = "850 dinara";
                }
                if (rbVelika.Checked)
                {
                    cena = "1350 dinara";
                }
            }
            if (cbIzaberiPicu.SelectedItem == "Quattro stagione")
            {
                if (rbMala.Checked)
                {
                    cena = "470 dinara";
                }
                if (rbSrednja.Checked)
                {
                    cena = "870 dinara";
                }
                if (rbVelika.Checked)
                {
                    cena = "1370 dinara";
                }
            }
            if (cbIzaberiPicu.SelectedItem == "Siciliana")
            {
                if (rbMala.Checked)
                {
                    cena = "490 dinara";
                }
                if (rbSrednja.Checked)
                {
                    cena = "890 dinara";
                }
                if (rbVelika.Checked)
                {
                    cena = "1500 dinara";
                }
            }
            if (cbIzaberiPicu.SelectedItem == "Italiana")
            {
                if (rbMala.Checked)
                {
                    cena = "420 dinara";
                }
                if (rbSrednja.Checked)
                {
                    cena = "640 dinara";
                }
                if (rbVelika.Checked)
                {
                    cena = "790 dinara";
                }
            }
            if (cbIzaberiPicu.SelectedItem == "Sopresa")
            {
                if (rbMala.Checked)
                {
                    cena = "270 dinara";
                }
                if (rbSrednja.Checked)
                {
                    cena = "490 dinara";
                }
                if (rbVelika.Checked)
                {
                    cena = "640 dinara";
                }
            }
            if (cbIzaberiPicu.SelectedItem == "Al tonno")
            {
                if (rbMala.Checked)
                {
                    cena = "490 dinara";
                }
                if (rbSrednja.Checked)
                {
                    cena = "940 dinara";
                }
                if (rbVelika.Checked)
                {
                    cena = "1450 dinara";
                }
            }
            if (cbIzaberiPicu.SelectedItem == "Calzone")
            {
                if (rbMala.Checked)
                {
                    cena = "360 dinara";
                }
                if (rbSrednja.Checked)
                {
                    cena = "520 dinara";
                }
                if (rbVelika.Checked)
                {
                    cena = "740 dinara";
                }
            }
            if (cbIzaberiPicu.SelectedItem == "Hawaii")
            {
                if (rbMala.Checked)
                {
                    cena = "420 dinara";
                }
                if (rbSrednja.Checked)
                {
                    cena = "650 dinara";
                }
                if (rbVelika.Checked)
                {
                    cena = "900 dinara";
                }
            }
            if (cbIzaberiPicu.SelectedItem == "Italiana")
            {
                if (rbMala.Checked)
                {
                    cena = "420 dinara";
                }
                if (rbSrednja.Checked)
                {
                    cena = "640 dinara";
                }
                if (rbVelika.Checked)
                {
                    cena = "790 dinara";
                }
            }
            if (cbIzaberiPicu.SelectedItem == "Sopresa")
            {
                if (rbMala.Checked)
                {
                    cena = "270 dinara";
                }
                if (rbSrednja.Checked)
                {
                    cena = "490 dinara";
                }
                if (rbVelika.Checked)
                {
                    cena = "640 dinara";
                }
            }
            if (cbIzaberiPicu.SelectedItem == "Al tonno")
            {
                if (rbMala.Checked)
                {
                    cena = "490 dinara";
                }
                if (rbSrednja.Checked)
                {
                    cena = "940 dinara";
                }
                if (rbVelika.Checked)
                {
                    cena = "1450 dinara";
                }
            }
            if (cbIzaberiPicu.SelectedItem == "Calzone")
            {
                if (rbMala.Checked)
                {
                    cena = "360 dinara";
                }
                if (rbSrednja.Checked)
                {
                    cena = "520 dinara";
                }
                if (rbVelika.Checked)
                {
                    cena = "740 dinara";
                }
            }
            if (cbIzaberiPicu.SelectedItem == "Hawaii")
            {
                if(rbMala.Checked)
                {
                    cena = "420 dinara";
                }
                if (rbSrednja.Checked)
                {
                    cena = "650 dinara";
                }
                if (rbVelika.Checked)
                {
                    cena = "900 dinara";
                }
            }


            Dodaj.Items.Add("Naziv pice:  " + cbIzaberiPicu.SelectedItem);
            Dodaj.Items.Add("Preuzimanje:  " + Dostava());
            Dodaj.Items.Add("Velicina:  " + Velicina());

            Dodaj.Items.Add("Prilozi:");
            if (cbKecap.Checked)
            {
                Dodaj.Items.Add("- Kecap");
            }
            if (cbMajonez.Checked)
            {
                Dodaj.Items.Add("- Majonez");
            }
            if (cbOrigano.Checked)
            {
                Dodaj.Items.Add("- Origano");
            }
            if (cbMasline.Checked)
            {
                Dodaj.Items.Add("- Masline");
            }
            if (cbJaje.Checked)
            {
                Dodaj.Items.Add("- Jaje");
            }
            if (cbPavlaka.Checked)
            {
                Dodaj.Items.Add("- Pavlaka");
            }
            if (cbMorskiPlodovi.Checked)
            {
                Dodaj.Items.Add("- Morski plodovi");
            }

            if (rbGotovinski.Checked)
            {
                placanje = "Gotovinsko placanje";
            }
            if (rbKreditnaKartica.Checked)
            {
                placanje = "Kreditnom karticom";
            }
            Dodaj.Items.Add("Nacin placanja: " + placanje);
            Dodaj.Items.Add("Vas racun iznosi: " + cena);

            btnIsprazni.Visible = true;
            btnRacun.Visible = true;
        }


    }
}

