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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            label5.Text = " ";
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            int yatirilanPara = Convert.ToInt32(textBox1.Text);

            Form1.bakiye += yatirilanPara;
            label2.Text = Convert.ToString(Form1.bakiye);
            label5.Text = "Paranız Yatırılmıştır";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form2 = new Form1();
            form2.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(Form1.bakiye);
        }
    }
}
