using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        public static int bakiye = 1000;
        private void button1_Click(object sender, EventArgs e)
        {
            
            Form5 form1 = new Form5();
            form1.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form2 = new Form6();
            form2.Show();
            this.Hide();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 form5 = new Form7();
            form5.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        { 
            Form8 form5 = new Form8();
            form5.Show();
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1 anaMneu = new Form1();
        }
    }
}
