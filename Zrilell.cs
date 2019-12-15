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
using System.Data.SqlClient;

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
           // string pattern1 = @"^(?=.*[0-9])(?=.*[!@#$%^&*])(?=.*[a-z])(?=.*[A-Z])[0-9a-zA-Z!@#$%^&*]{6,}$";

            Regex r = new Regex(pattern, RegexOptions.IgnoreCase);
          //  Regex t = new Regex(pattern1, RegexOptions.IgnoreCase);

            bool matched = r.Match(textBox1.Text).Success;
          //  bool matched1 = t.Match(textBox2.Text).Success;
            if (comboBox1.Text == "" || textBox4.Text == ""|| comboBox2.Text == "" || textBox5.Text == "") MessageBox.Show("Есть пустые поля");
            else if (matched != true) MessageBox.Show("Мыло то не торот");
           // else if (matched1 != true) MessageBox.Show("Павроль то не торот, пароль должен содержать как минимум 6 символов, рсреди них должен быть специальный символ");

            else if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("passwords not match");
                bool passmatch = false;
            }
            else
            {
                string conn = @"Data Source=DESKTOP-EHCC0UU;Initial Catalog=g464_Golubtsov;Integrated Security=true;MultipleActiveResultSets=True";
                string str = "INSERT INTO [user] ([Email],[Password],[FirstName],[LastName],[RoleId]) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','Z')";
               // string str2 = "INSERT INTO [Runner] ([Email],[Gender],[DateOfBirth],[CountryCode]) VALUES ('" + textBox1.Text + "','" + comboBox1.Text + "','" + data + "','" + comboBox2.Text + "')";
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                //тут будет отправка на сервер
                MessageBox.Show("Done!");
              
                this.Close();
               

            }
            
        }

        private void Zrilell_Load(object sender, EventArgs e)
        {
            string conn = @"Data Source=DESKTOP-EHCC0UU;Initial Catalog=g464_Golubtsov;Integrated Security=true;MultipleActiveResultSets=True";
            string str = "SELECT [CountryName] FROM [Country]";
            string str1  = "SELECT [Gender] FROM [Gender]";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                comboBox2.Items.Add(rdr.GetString(0));
            }
            SqlConnection con1 = new SqlConnection(conn);
            con1.Open();
            SqlCommand cmd1 = new SqlCommand(str1, con1);
            SqlDataReader rdr1 = cmd1.ExecuteReader();

            while (rdr1.Read())
            {
                comboBox1.Items.Add(rdr1.GetString(0));
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mains open = new Mains();
            open.Show();
            this.Hide();
        }
    }
}
