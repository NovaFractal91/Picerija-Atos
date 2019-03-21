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
    public partial class Form5 : Form
    {
        string sifra = "picerija";
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == sifra.ToLower())
            {
                Form6 forma6 = new Form6();
                this.Hide();
                forma6.Show();

            }
            else
            {
                
               DialogResult dijalog= MessageBox.Show("Uneli ste pogresnu sifru! Proverite da li je dugme CAPS LOCK ukljuceno. Da li zelite ponovo da pokusate?", "Picerija Atos",MessageBoxButtons.YesNo);
               textBox1.Clear();
                if(dijalog==DialogResult.No)
                {
                    Form1 forma1 = new Form1();
                    this.Hide();
                    forma1.Show();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 forma1 = new Form1();
            this.Hide();
            forma1.Show();
        }
    }
}
