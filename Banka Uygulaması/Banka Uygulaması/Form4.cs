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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form2 = new Form1();
            form2.Show();  
            this.Hide();   
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int havale=Convert.ToInt32(textBox1.Text);
            string ıban = Convert.ToString(textBox2.Text);
           int bakiye=Convert.ToInt32(textBox1.Text);
            if((ıban.Length)==5)
            {
                label5.Text = "Havale Başarılı";
            }
            else
            {
                label5.Text = "Ibanınız 5 Haneli Olmalıdır yada Paranız Yetersizdir.";
            }

            if (havale > Form1.bakiye)
            {
                MessageBox.Show("Ibanınız 5 Haneli Olmalıdır yada Paranız Yetersizdir.");
            }
            else
            {
                label5.Text = "Doğru Giriş Yaptınız";
                Form1.bakiye = Form1.bakiye - havale;
            }
            label2.Text = Form1.bakiye.ToString();
        }
    }
}
