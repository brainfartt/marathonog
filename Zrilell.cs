using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MarATHON
{
    public partial class Zrilell : Form
    {
        public Zrilell()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pattern = @"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}$";
            string pattern1 = @"^(?=.*[0-9])(?=.*[!@#$%^&*])(?=.*[a-z])(?=.*[A-Z])[0-9a-zA-Z!@#$%^&*]{6,}$";

            Regex r = new Regex(pattern, RegexOptions.IgnoreCase);
            Regex t = new Regex(pattern1, RegexOptions.IgnoreCase);

            bool matched = r.Match(textBox1.Text).Success;
            bool matched1 = t.Match(textBox2.Text).Success;
            if (comboBox1.Text == "" || textBox4.Text == ""|| comboBox2.Text == "" || textBox5.Text == "") MessageBox.Show("Есть пустые поля");
            else if (matched != true) MessageBox.Show("Мыло то не торот");
            else if (matched1 != true) MessageBox.Show("Павроль то не торот, пароль должен содержать как минимум 6 символов, рсреди них должен быть специальный символ");

            else if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("passwords not match");
                bool passmatch = false;
            }
            else
            {
                //тут будет отправка на сервер

            }
        }
    }
}
