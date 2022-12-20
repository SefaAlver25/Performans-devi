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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {

                int havale = Convert.ToInt32(textBox1.Text);
                string ıban = Convert.ToString(textBox2.Text);
                int bakiye = Convert.ToInt32(textBox1.Text);
                if ((ıban.Length) == 5 && havale < Form1.bakiye)
                {
                    label5.Text = "Havale Başarılı";
                    Form1.bakiye = Form1.bakiye - havale;
                }
                else if ((ıban.Length) <= 5 || (ıban.Length) >= 5)
                {
                    label5.Text = "Ibanınız 5 Haneli Olmalıdır ";
                }
                else
                {
                    MessageBox.Show("Paranız Yetersizdir");
                }

                label2.Text = Form1.bakiye.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form5 = new Form1();
            form5.Show();
            this.Hide();

        }
    }
}
