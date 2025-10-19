using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4
{
    public partial class Form2 : Form
    {
        public Form2(string mobile, string firstName, string lastName, string sex, string status, string birthday, string location, Image profileImage)
        {
            InitializeComponent();

            labelMobile.Text = "Mobile: " + mobile;
            labelName.Text = "Name: " + firstName + " " + lastName;
            labelSex.Text = "Sex: " + sex;
            labelStatus.Text = "Status: " + status;
            labelBirthday.Text = "Birthday: " + birthday;
            labelLocation.Text = "Location: " + location;

            if (profileImage != null)
            {
                pictureBoxProfile.Image = profileImage;
                pictureBoxProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
