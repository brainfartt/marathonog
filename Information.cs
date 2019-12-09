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
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
            string filePath = @"C:\Users\namemustbefree\Downloads\MarATHON\MarATHON\IMG\imgs\1.jpg";
            Bitmap MyImage = new Bitmap(filePath);

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox1.Image = (Image)MyImage;

           

        //    string filePath3 = @"C:\Users\namemustbefree\Downloads\MarATHON\MarATHON\IMG\imgs\3.jpg";
        //    Bitmap MyImage3 = new Bitmap(filePath3);

        //    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

        //    pictureBox3.Image = (Image)MyImage3;

        //    string filePath4 = @"C:\Users\namemustbefree\Downloads\MarATHON\MarATHON\IMG\imgs\4.jpg";
        //    Bitmap MyImage4 = new Bitmap(filePath4);

        //    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;

        //    pictureBox4.Image = (Image)MyImage4;

        //    string filePath5 = @"C:\Users\namemustbefree\Downloads\MarATHON\MarATHON\IMG\imgs\5.jpg";
        //    Bitmap MyImage5 = new Bitmap(filePath5);

        //    pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;

        //    pictureBox5.Image = (Image)MyImage5;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
