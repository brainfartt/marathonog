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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 6;
            dataGridView1.ColumnCount = 4;
           
            string conn = @"Data Source=DESKTOP-EHCC0UU;Initial Catalog=g464_Golubtsov;Integrated Security=true;MultipleActiveResultSets=True";
            string str = "SELECT [WhatStuff],[Count] FROM [Stuff]";

            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            int i = 0;
            while (rdr.Read())
            {
                dataGridView1.Rows[i].Cells[0].Value = rdr.GetString(0);
                dataGridView1.Rows[i].Cells[1].Value = rdr.GetInt32(1);
                i++;
            }
            string str1 = "SELECT [RaceKitOptionId] FROM [Registration]";
            SqlConnection con1 = new SqlConnection(conn);
            con1.Open();
            SqlCommand cmd1 = new SqlCommand(str1, con1);
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            int A = 0;
            int B = 0;
            int C = 0;

            while (rdr1.Read())
            {
                if (rdr1.GetString(0) == "A")
                    A++;
                if (rdr1.GetString(0) == "B")
                    B++;
                if (rdr1.GetString(0) == "C")
                    C++;
            }
            dataGridView1.Rows[0].Cells[2].Value = A + B + C;
            dataGridView1.Rows[1].Cells[2].Value = A + B + C;
            dataGridView1.Rows[2].Cells[2].Value =  B + C;
            dataGridView1.Rows[3].Cells[2].Value =  B + C;
            dataGridView1.Rows[4].Cells[2].Value =  C;
            dataGridView1.Rows[5].Cells[2].Value =  C;

            for(int j=0;j<6;j++)
                dataGridView1.Rows[j].Cells[3].Value = Convert.ToInt32(dataGridView1.Rows[j].Cells[1].Value) - Convert.ToInt32(dataGridView1.Rows[j].Cells[2].Value);
            dataGridView1.Columns[0].HeaderText = "name of inventory";
            dataGridView1.Columns[1].HeaderText = "how much we have";
            dataGridView1.Columns[2].HeaderText = "how much we need";
            dataGridView1.Columns[3].HeaderText = "how much left after";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.Hide();
            this.Close();
            InventoryAdd frm = new InventoryAdd();
            frm.Show();


        }


    }
}
