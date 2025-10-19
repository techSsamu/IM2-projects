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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void submitRegistration_Click(object sender, EventArgs e)
        {
            string userMobile = mobile.Text;
            string userFirstName = fName.Text;
            string userLastName = lName.Text;

            string userSex = male.Checked ? "Male" :
                             female.Checked ? "Female" :
                             others.Checked ? "Others" : "Not Specified";

            string userStatus = status.SelectedItem?.ToString() ?? "Not Specified";
            string userBirthday = birthday.Value.ToString("yyyy-MM-dd");
            string userLocation = location.Text;

            
            Image profilePicture = pictureBox1.Image;

            
            Form2 outputForm = new Form2(userMobile, userFirstName, userLastName, userSex, userStatus, userBirthday, userLocation, profilePicture);
            outputForm.Show();
        }

        private void mobile_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void fName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelName2_TextChanged(object sender, EventArgs e)
        {

        }

        private void status_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void others_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void birthday_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void location_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
