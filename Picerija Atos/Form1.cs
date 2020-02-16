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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnSajt_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.picerija-atos.com/index.html");
        }

        private void btnNaruci_Click(object sender, EventArgs e)
        {
            Form2 forma2 = new Form2();
            this.Hide();
            forma2.Show();
        }

        private void zaposleniToolStripMenuItem_Click(object sender, EventArgs e)
        {
             DialogResult dijalog = MessageBox.Show("Da li ste zaposleni u piceriji?", "Radnici", MessageBoxButtons.YesNo);
            if (dijalog == DialogResult.Yes)
            {
                Form5 forma5 = new Form5();
                this.Hide();
                forma5.Show();
            }
            else if (dijalog == DialogResult.No)
            {
                Form1 forma1 = new Form1();
                this.Hide();
                forma1.Show();
            }
        }

        private void dizajnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog BojaPozadine = new ColorDialog();

            if (BojaPozadine.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.BackColor = BojaPozadine.Color;
            }
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nikola Bosnic 131/2015", "Visoka tehnička škola");
        }

        private void informacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 forma4 = new Form4();
            this.Hide();
            forma4.Show();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        }
    }

