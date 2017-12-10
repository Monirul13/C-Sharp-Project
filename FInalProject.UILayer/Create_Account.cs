using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;
using FinalProject.DataAccessLayer;
using FinalProject.EntityLayer;
using FinalProject.FrameworkLayer;

namespace FInalProject.UILayer
{
    public partial class Create_Account : MetroForm
    {
        Home_Page homepage;

        public Create_Account(Home_Page homepage)
        {
            InitializeComponent();
            this.homepage = homepage;
        }

        private void Create_Account_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            UserInfo userObj = new UserInfo();
            UserData ud=new UserData();
            
            userObj.Name = nameTextBox.Text;
            userObj.Contact = contactTextBox.Text;
            userObj.Email = emailTextBox.Text;
            userObj.BloodGroup = bloodgrpComboBox.Text;
            userObj.Religion = religionComboBox.Text;
            userObj.Gender = gendreComboBox.Text;
            userObj.LastDateOfBloodDonatin = metroDateTime.Text;
            userObj.Division = divisionComboBox.Text;
            userObj.Area = areaTextBox.Text;
            userObj.PassWord = passwordTextBox.Text;


            bool x = ud.Insert(userObj);

            if (x==true)
            {
                MessageBox.Show("Insertion  Successful");
            }
            else
            {
                MessageBox.Show("Insertion Fail");
            }


        }

        private void backButton_Click(object sender, EventArgs e)
        {
            homepage.Show();
            this.Close();
        }
    }
}
