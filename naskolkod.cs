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
    public partial class naskolkod : Form
    {
        public naskolkod()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void naskolkod_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.ImageLocation = @"C:\Users\namemustbefree\Downloads\MarATHON\MarATHON\IMG\imgs\1.jpg";
            string conn = @"Data Source=DESKTOP-EHCC0UU;Initial Catalog=g464_Golubtsov;Integrated Security=true;MultipleActiveResultSets=True";
            string str = "SELECT [EventName],[EventId] FROM [Event]";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                comboBox1.Items.Add(rdr.GetString(0));
            }

            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str2 = "SELECT [EventId] FROM [Event] WHERE [EventName]='" + comboBox1.Text + "'";

            string conn = @"Data Source=DESKTOP-EHCC0UU;Initial Catalog=g464_Golubtsov;Integrated Security=true;MultipleActiveResultSets=True";

            SqlConnection con2 = new SqlConnection(conn);
            con2.Open();
            string eventid = "";
            SqlCommand cmd2 = new SqlCommand(str2, con2);
            SqlDataReader rdr2 = cmd2.ExecuteReader();
            while (rdr2.Read())
                eventid = rdr2.GetString(0);


            string str1 = "SELECT AVG([RaceTime]) FROM [RegistrationEvent] WHERE [EventId]='" + eventid + "'";
            SqlConnection con1 = new SqlConnection(conn);
            con1.Open();
            SqlCommand cmd1 = new SqlCommand(str1, con1);
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            int asd = 0;
            //label1.Text = eventid + " " + comboBox1.SelectedValue+ " "+comboBox1.Text;
            while (rdr1.Read())
                asd = rdr1.GetInt32(0);
            label1.Text = "среднее время прохождения этого марафона: "+((asd-asd%60)/60).ToString()+" минут "+(asd%60).ToString()+" секунд";

        }
    }
}
