using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Banka_Uygulaması
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            label5.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Kredicekilen = Convert.ToInt32(textBox1.Text);
     
       
                label5.Text = "Kredi Çekilmiştir";
                Form1.bakiye = Form1.bakiye + Kredicekilen;
         
            label2.Text = Form1.bakiye.ToString();



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
