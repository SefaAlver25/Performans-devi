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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(Form1.bakiye);
            label5.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cekilenPara = Convert.ToInt32(textBox1.Text);
            if(cekilenPara > Form1.bakiye)
            {
                MessageBox.Show("Bakiyeniz Yetersizdir. Lütfen Para Yatırınız.");
            }
            else
            {
                label5.Text = "Paranız Çekilmiştir";
                Form1.bakiye = Form1.bakiye - cekilenPara;
            }
            label2.Text = Form1.bakiye.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form2 = new Form1();
            form2.Show();
            this.Hide();
        }
    }
}
