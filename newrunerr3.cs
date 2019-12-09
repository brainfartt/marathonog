using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace MarATHON
{
    public partial class newrunerr3 : Form
    {


        public newrunerr3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            newrunner1 kavno = new newrunner1();


         


            string data = kavno.dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss.hs");
            string conn = "Data Source=127.0.0.1;Initial Catalog=g464_Golubtsov;User ID=student;Password=student";
            string str = "INSERT INTO [user] ([Email],[Password],[FirstName],[LastName],[RoleId]) VALUES ('" + kavno.textBox1.Text + "','" + kavno.textBox7.Text + "','" + kavno.textBox6.Text + "','" + kavno.textBox5.Text + "','R')";
            string str2 = "INSERT INTO [Runner] ([Email],[Gender],[DateOfBirth],[CountryCode]) VALUES ('" + kavno.textBox1.Text + "','" + kavno.comboBox1.Text + "','" + data + "','" + kavno.comboBox2.Text + "')";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand(str2, con);
            cmd2.ExecuteNonQuery(); 
            con.Close();

            Dotv8 open = new Dotv8();
            open.Show();
            this.Close();
        }







        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label9.Text = Convert.ToString(Convert.ToInt32(label9.Text) + 145);
            }
            if (checkBox2.Checked == true)
            {
                label9.Text = Convert.ToString(Convert.ToInt32(label9.Text) + 75);
            }
            if (checkBox3.Checked == true)
            {
                label9.Text = Convert.ToString(Convert.ToInt32(label9.Text) + 5);
            }

        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label9.Text = Convert.ToString(Convert.ToInt32(label9.Text) + 0);
            }
            if (radioButton2.Checked == true)
            {
                label9.Text = Convert.ToString(Convert.ToInt32(label9.Text) + 20);
            }
            if (radioButton3.Checked == true)
            {
                label9.Text = Convert.ToString(Convert.ToInt32(label9.Text) + 45);
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            info open = new info();
            open.Show();
        }

        private void newrunerr3_Load(object sender, EventArgs e)
        {

        }
    }
}
