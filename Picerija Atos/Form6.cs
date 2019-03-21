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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void pocetnaToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void izadjiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FontDialog promeni = new FontDialog();
            {
                if (promeni.ShowDialog() == DialogResult.OK)
                {
                    rtxtInformacije.Font = promeni.Font;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (rbPlava.Checked == true)
            {
                this.BackColor = Color.Blue;
            }
            if (rbCrvena.Checked == true)
            {
                this.BackColor = Color.Red;
            }
            if (rbZelena.Checked == true)
            {
                this.BackColor = Color.Green;
            }
            if (rbNarandzasta.Checked == true)
            {
                this.BackColor = Color.Orange;
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            string[] radnik = {"Aleksandar Stosic","Milos Joksimovic","Olivera Rankovic","Jovan Brkic","Marija Novakovic","Jovana Petrovic","Stefan Kalinic","Zeljko Mladenovic" };
            
            foreach (string podatak in radnik)
            {
                comboBox1.Items.Add(podatak);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                rtxtInformacije.Text = "Ime: Aleksandar" + "\r\n"
                              + "Prezime: Stosic" + "\r\n"
                              + "Zanimanje: Konobar" + "\r\n"
                              + "Smena: Prva ";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                rtxtInformacije.Text = "Ime: Milos" + "\r\n"
                              + "Prezime: Joksimovic" + "\r\n"
                              + "Zanimanje: Pizza majstor" + "\r\n"
                              + "Smena: Prva ";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                rtxtInformacije.Text = "Ime: Olivera" + "\r\n"
                              + "Prezime: Rankovic" + "\r\n"
                              + "Zanimanje: Cistacica" + "\r\n"
                              + "Smena: Prva ";
            }
            if (comboBox1.SelectedIndex == 3)
            {
                rtxtInformacije.Text = "Ime: Jovan" + "\r\n"
                              + "Prezime: Brkic" + "\r\n"
                              + "Zanimanje: Nocni cuvar" + "\r\n"
                              + "Smena: Treca ";
            }
            if (comboBox1.SelectedIndex == 4)
            {
                rtxtInformacije.Text = "Ime: Marija" + "\r\n"
                              + "Prezime: Novakovic" + "\r\n"
                              + "Zanimanje: Pizza majstor" + "\r\n"
                              + "Smena: Druga ";
            }
            if (comboBox1.SelectedIndex == 5)
                rtxtInformacije.Text = "Ime: Jovana" + "\r\n"
                              + "Prezime: Petrovic" + "\r\n"
                              + "Zanimanje: Konobarica" + "\r\n"
                              + "Smena: Druga ";
            if (comboBox1.SelectedIndex == 6)
            {
                rtxtInformacije.Text = "Ime: Stefan" + "\r\n"
                              + "Prezime: Kalinic" + "\r\n"
                              + "Zanimanje: Vozac" + "\r\n"
                              + "Smena: Prva ";
            }
            if (comboBox1.SelectedIndex == 7)
            {
                rtxtInformacije.Text = "Ime: Zeljko" + "\r\n"
                              + "Prezime: Mladenovic" + "\r\n"
                              + "Zanimanje: Vozac" + "\r\n"
                              + "Smena: Druga ";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rtxtInformacije.Text = "Nova godina" + "\r\n"
                                + "Sretenje" + "\r\n"
                                  + "Bozic" + "\r\n"
                                      + "Uskrs";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rtxtInformacije.Clear();
        }
    }
}
