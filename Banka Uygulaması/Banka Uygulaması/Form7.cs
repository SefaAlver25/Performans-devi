﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_Uygulaması
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sifre = Convert.ToString(textBox1.Text);
            if ((sifre.Length) == 4)
            {

                label2.Text = "Giriş Başarılı";
                Form9 form2 = new Form9();
                form2.Show();
                this.Hide();
            }
            else
            {
                label2.Text = "Eksik yada Fazla Karakter girdiniz -----Tekrar Deneyiniz-----";
            }
        }
    }
    }