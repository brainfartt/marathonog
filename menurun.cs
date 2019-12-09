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
    public partial class menurun : Form
    {
        public menurun()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            redaktbegun yyy22 = new redaktbegun();
            yyy22.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            results yyy22 = new results();
            yyy22.Show();
        }
    }
}
