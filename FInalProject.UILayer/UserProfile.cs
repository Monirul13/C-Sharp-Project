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
    public partial class UserProfile :MetroForm
    {
        UserAccount uaccount;

        public UserProfile(UserAccount uaccount)
        {
            InitializeComponent();
            this.uaccount = uaccount;
        }
           

        private void UserProfile_Load(object sender, EventArgs e)
        {

        }

        private void contactLabel_Click(object sender, EventArgs e)
        {

        }

        private void bloodgroupLabel_Click(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Home_Page homePage = new Home_Page();
            homePage.Show();
            this.Close();
        }

        private void eeeditButton_Click(object sender, EventArgs e)
        {
            Edit_Profile editProfile = new Edit_Profile(this);
            editProfile.Show();

            //editProfile.editnameTextBox.Text = list.Name;
             this.Hide();
        }
    }
}
