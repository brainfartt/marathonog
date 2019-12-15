using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarATHON
{
    public partial class dopform : Form
    {
        public dopform()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan t = Program.start - DateTime.Now;
            DATA6.Text = t.Days.ToString() + " days, " +
                t.Hours.ToString() + " hours, " +
                t.Minutes.ToString() + " minutes";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            blagorg frm = new blagorg();
            frm.Show();
        }

        private void Marafon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Information frm = new Information();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            BMI frm = new BMI();
            frm.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            naskolkod frm = new naskolkod();
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            naskolkod frm = new naskolkod();
            frm.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Mains open = new Mains();
            open.Show();
            this.Close();

        }
    }
}
