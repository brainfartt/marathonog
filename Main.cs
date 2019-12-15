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
    public partial class Mains : Form
    {
        public Mains()
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

        private void button1_Click(object sender, EventArgs e)
        {
              this.Hide();
              Sponsor frm = new Sponsor();
              frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            run yyy = new run();
            yyy.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            dopform yyy = new dopform();
            yyy.Show();  
        }

        private void Login_Click(object sender, EventArgs e)
        {
           this.Hide();
            newrunner yyy = new newrunner();
            yyy.Show();  
        }

        private void button5_Click(object sender, EventArgs e)
        {
            redaktbegun yyy = new redaktbegun();
            yyy.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            naskolkod yyy = new naskolkod();
            yyy.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Inventory yyy = new Inventory();
            yyy.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zrilell yyy = new Zrilell();
            yyy.Show();
            this.Hide();
        }

        private void Mains_Load(object sender, EventArgs e)
        {

        }

        private void Mains_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
    }

