using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace MarATHON
{
    public partial class redaktbegun : Form
    {
        public redaktbegun()
        {
            InitializeComponent();
           
            
        }

        private void Redaktbegun_Load(object sender, EventArgs e)
        {

            //string conn = "Data Source=127.0.0.1;Initial Catalog=g464_Golubtsov;User ID=student;Password=student";
            // string conn = "data source = win - umavbp2dft7\sqlexpress; initial catalog = g464_golubtsov; integrated security = true";
            // string str = "select [Email],[Password],[RoleId] FROM [User] WHERE [Email]='" + textBox1.Text + "' AND [Password]='" + textBox2.Text + "'";
           

            // newrunner1 kavno1 = new newrunner1();

            //textBox1.Text = kavno1.textBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            //string email = textBox5.Text;
            string name = textBox6.Text;
            string surname = textBox9.Text;
            string password = textBox8.Text;
            string sex = comboBox3.Text;
            string date = dateTimePicker2.Text;
            string country = comboBox4.Text;


            string pattern = @"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}$";
            string pattern1 = @"^(?=.*[0-9])(?=.*[!@#$%^&*])(?=.*[a-z])(?=.*[A-Z])[0-9a-zA-Z!@#$%^&*]{6,}$";

            Regex r = new Regex(pattern, RegexOptions.IgnoreCase);
            Regex t = new Regex(pattern1, RegexOptions.IgnoreCase);

            //bool matched = r.Match(textBox5.Text).Success;
            bool matched1 = t.Match(textBox8.Text).Success;
            if (comboBox3.Text == "" || textBox6.Text == "" || dateTimePicker2.Text == "" || comboBox4.Text == "" || textBox9.Text == "") MessageBox.Show("Есть пустые поля");
           // else if (matched != true) MessageBox.Show("Мыло то не торот");
            else if (matched1 != true) MessageBox.Show("Павроль то не торот, пароль должен содержать как минимум 6 символов, рсреди них должен быть специальный символ");
            
            else if (textBox10.Text != textBox11.Text)
            {
                MessageBox.Show("passwords not match");
                bool passmatch = false;
            }
            else
            {
                //тут будет отправка на сервер
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "image files (*.jpg)|*.jpg|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    Bitmap MyImage = new Bitmap(filePath);

                    // int xSize = MyImage.Height;
                    // int ySize = MyImage.Width;
                    // pictureBox2.ClientSize = new Size(xSize, ySize);
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

                    pictureBox2.Image = (Image)MyImage;
                    textBox12.Text = filePath;
                    //pictureBox2.Update();
                    // MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void redaktbegun_Load_1(object sender, EventArgs e)
        {
            string conn = @"Data Source=DESKTOP-EHCC0UU;Initial Catalog=g464_Golubtsov;Integrated Security=true;MultipleActiveResultSets=True";
             string str = "SELECT [Email],[Password],[LastName],[FirstName] FROM [User] WHERE [Email]='"+newrunner.login+"'";
             SqlConnection con = new SqlConnection(conn);
             con.Open();
             SqlCommand cmd = new SqlCommand(str, con);
             SqlDataReader rdr = cmd.ExecuteReader();
            //textBox11.Text = cmd.ToString();
            //textBox10.Text = newrunner.login;
            if (rdr.Read() == true)
            {
                label22.Text = rdr.GetString(0);
                textBox6.Text = rdr.GetString(3);
                textBox9.Text = rdr.GetString(2);
                textBox10.Text = rdr.GetString(1);
            }
            rdr.Close();
           
            str = "SELECT [Gender],[DateOfBirth],[CountryCode] FROM [Runner] WHERE [Email]='" + newrunner.login + "'";
            //textBox11.Text = "ass";
            SqlCommand cmd1 = new SqlCommand(str, con);
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            if (rdr1.Read() == true)
            {
                comboBox3.Text = rdr1.GetString(0);
                char[] charSeparators = new char[] { ' ' };
                string[] result;
               // result  = rdr1.GetString(1).Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
                 dateTimePicker2.Value = rdr1.GetDateTime(1) ;
                //textBox5.Text = result[0];
                comboBox4.Text = rdr1.GetString(2);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
