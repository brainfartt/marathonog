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
    public partial class BMI : Form
    {
        public BMI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath="";
            string height = textBox1.Text;
            double hg = Int32.Parse(height);
            string weight = textBox2.Text;
            int wg = Int32.Parse(weight);
            hg =hg/100;
            string sex;
            if (checkBox1.Checked)
                sex = "дядя";
            else sex = "тетя";
            if (wg / (hg * hg) > 25)
            {
                filePath = @"C:\Users\namemustbefree\Downloads\MarATHON\MarATHON\IMG\imgs\1558449975133279818.jpg";
                label4.Text = sex + ", да вы жирный";
            }
            if (wg / (hg * hg) <= 25 && wg / (hg * hg) >=18.5)
            {
                filePath = @"C:\Users\namemustbefree\Downloads\MarATHON\MarATHON\IMG\imgs\244.jpg";
                label4.Text = sex + ", да вы нормальный";
            }

            if (wg / (hg * hg) < 18.5)
            {
                filePath = @"C:\Users\namemustbefree\Downloads\MarATHON\MarATHON\IMG\imgs\223.jpg";
                label4.Text = sex + ", да вы худой";
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Bitmap MyImage = new Bitmap(filePath);
            pictureBox1.Image = MyImage;
        }
    }
}
