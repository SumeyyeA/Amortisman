using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TNP_KOMBOX_2022
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "")
            {

                MessageBox.Show("Kullanıcı adı veya şifre boş bırakılamaz.");
            }
            else
            {
                if (textBox1.Text == "hüseyin" && textBox2.Text == "123" || textBox1.Text == "güven" && textBox2.Text == "123" || textBox1.Text == "ibrahim" && textBox2.Text == "123")
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış");
                }
            }

        }
    }
}
