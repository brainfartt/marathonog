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
    public partial class results : Form
    {
        public results()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void results_Load(object sender, EventArgs e)
        {
            string conn = @"Data Source=DESKTOP-EHCC0UU;Initial Catalog=g464_Golubtsov;Integrated Security=true;MultipleActiveResultSets=True";
            string str = "SELECT [Gender],[DateOfBirth],[RunnerId] FROM [Runner] WHERE [Email]='" + newrunner.login + "'";

            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read() == true)
            {
                label3.Text = rdr.GetString(0);

                DateTime year = rdr.GetDateTime(1);

                int id = rdr.GetInt32(2);

                int vozr = DateTime.Now.Year - year.Year;

                if (vozr < 18)
                    label5.Text = ("до 18");
                if (vozr >= 18 && vozr < 29)
                    label5.Text = ("от 18 до 29");
                if (vozr >= 29 && vozr < 39)
                    label5.Text = ("от 29 до 39");
                if (vozr >= 39 && vozr < 49)
                    label5.Text = ("от 39 до 49");
                if (vozr >= 49 && vozr < 70)
                    label5.Text = ("от 49 до 70"); 
                if (vozr > 70)
                    label5.Text = ("больше 70");

                string str1 = "SELECT [EventId],[RaceTime] FROM [RegistrationEvent] WHERE [RegistrationId]='" + id + "'";
                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader rdr1 = cmd1.ExecuteReader();

                if (rdr1.Read() == true)
                {

                    int count = rdr1.FieldCount;
                    //label1.Text = count.ToString();
                    int j = 0;
                    label6.Text = "количество ваших марафонов - " + 1;
                    dataGridView1.RowCount = count;
                    dataGridView1.ColumnCount = 2;
                    int coutt = 0;
                    string str3 = "SELECT [EventName] FROM [Event] WHERE [EventId]='" + rdr1[0].ToString() + "'";
                    SqlCommand cmd3 = new SqlCommand(str3, con);
                    SqlDataReader rdr3 = cmd3.ExecuteReader();
                    if (rdr3.Read() == true)
                    {
                       label1.Text = rdr3.GetString(0);
                        if (!rdr3.IsDBNull(0))
                             dataGridView1.Rows[coutt].Cells[0].Value = rdr3.GetString(0);
                    }
                    if (!rdr1.IsDBNull(1))
                                dataGridView1.Rows[coutt].Cells[1].Value = rdr1.GetString(1);
                            else
                                dataGridView1.Rows[coutt].Cells[1].Value = "вы не добежали";
                        coutt++;
                        // j = j + 2;
                    
                }
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            menurun open = new menurun();
            open.Show();
            this.Hide();
        }
    }
}
