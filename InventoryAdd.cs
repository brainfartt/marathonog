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
    public partial class InventoryAdd : Form
    {
        public InventoryAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=DESKTOP-EHCC0UU;Initial Catalog=g464_Golubtsov;Integrated Security=true;MultipleActiveResultSets=True";
            string str = "SELECT [WhatStuff],[Count] FROM [Stuff]";

            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            int i = 0;
            int[] array = new int[6];
            while (rdr.Read())
            {
                array[i] = rdr.GetInt32(1);
                i++;
            }

            //textBox1.Text = array[0].ToString();
            //textBox2.Text = array[1].ToString();
            //textBox3.Text = array[2].ToString();
            //textBox4.Text = array[3].ToString();
            //textBox5.Text = array[4].ToString();
            //textBox7.Text = array[5].ToString();

            array[0] += Convert.ToInt32(textBox1.Text);
            array[1] += Convert.ToInt32(textBox2.Text);
            array[2] += Convert.ToInt32(textBox3.Text);
            array[3] += Convert.ToInt32(textBox4.Text);
            array[4] += Convert.ToInt32(textBox5.Text);
            array[5] += Convert.ToInt32(textBox7.Text);

            string str1 = "UPDATE [Stuff] SET[Count]=" + array[0] + " WHERE [WhatStuff]='nomer'";
            string str2 = "UPDATE [Stuff] SET[Count]=" + array[1] + " WHERE [WhatStuff]='RFID'";
            string str3 = "UPDATE [Stuff] SET[Count]=" + array[2] + " WHERE [WhatStuff]='beisbolka'";
            string str4 = "UPDATE [Stuff] SET[Count]=" + array[3] + " WHERE [WhatStuff]='water'";
            string str5 = "UPDATE [Stuff] SET[Count]=" + array[4] + " WHERE [WhatStuff]='shirt'";
            string str6 = "UPDATE [Stuff] SET[Count]=" + array[5] + " WHERE [WhatStuff]='buklet'";

            SqlCommand cmd1 = new SqlCommand(str1, con);
            SqlCommand cmd2 = new SqlCommand(str2, con);
            SqlCommand cmd3 = new SqlCommand(str3, con);
            SqlCommand cmd4 = new SqlCommand(str4, con);
            SqlCommand cmd5 = new SqlCommand(str5, con);
            SqlCommand cmd6 = new SqlCommand(str6, con);


            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            cmd4.ExecuteNonQuery();
            cmd5.ExecuteNonQuery();
            cmd6.ExecuteNonQuery();

            Inventory frm = new Inventory();
            frm.Show();
            this.Close();


        }

        private void InventoryAdd_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
