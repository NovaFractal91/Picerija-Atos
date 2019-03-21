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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string imePrezime
        {
            set { txtIme.Text=value; }
        }
        public string grad
        {
            set { txtGrad.Text = value; }
        }
        public string adresa
        {
            set { txtAdresa.Text = value; }
        }
        public string brojTelefona
        {
            set { mtxtTelefon.Text = value; }
        }
        public string brojKartice
        {
            set {mtxtBrojKartice.Text=value; }
        }
        public string imeRadnika
        {
            set { txtImeRadnika.Text = value; }
        }
        public string prezimeRadnika
        {
            set { txtPrezimeRadnika.Text = value; }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            labelClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void pocetnaStranicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 forma1 = new Form1();
            this.Hide();
            forma1.Show();
        }

        private void narucivanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 forma2 = new Form2();
            this.Hide();
            forma2.Show();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var lista = Form2.lista;

            foreach (var item in lista)
            {
                lbRacun.Items.Add(item);
            }
            txtIme.ReadOnly = true;
            txtGrad.ReadOnly = true;
            txtAdresa.ReadOnly = true;
            txtImeRadnika.ReadOnly = true;
            txtPrezimeRadnika.ReadOnly = true;
            mtxtTelefon.ReadOnly = true;
            mtxtBrojKartice.ReadOnly = true;
        }
    }
}
