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
    public partial class UserAccount : MetroForm
    {
        Home_Page homepage;

       

        string str;

        public UserAccount(Home_Page homepage)
        {
            InitializeComponent();
            userPasswordTextBox.PasswordChar='*';
            this.homepage = homepage;
        }

        private void UserAccount_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void userLoginButton_Click(object sender, EventArgs e)
        {
            List<UserInfo> list = new List<UserInfo>();
           

            UserData ud = new UserData();
            list=ud.GetUserList();

            string username  = userNameTextBox.Text;
            string password = userPasswordTextBox.Text;


            for (int i = 0; i < list.Count; i++)
             {
                 string userName = list[i].Name;
                 string pass = list[i].PassWord;
                 // = list[i];
                

                 
                 if(userName.Equals(null)&&pass.Equals(null))
                 {
                     MessageBox.Show("Invalid Password or Name\nplease try again");
                     break;
                 }
                
                else if (username.Equals(userName) && password.Equals(pass))
                 {
                      str = Convert.ToString(list[i]);

                    UserProfile uprofile = new UserProfile(this);
                     uprofile.Show();
                     this.Hide();

                     

                     uprofile.upnameLabel.Text = list[i].Name;
                     uprofile.upcontactLabel.Text = list[i].Contact;
                     uprofile.upemailLabel.Text = list[i].Email;
                     uprofile.upbgpanel.Text = list[i].BloodGroup;
                     uprofile.upreligionLabel.Text = list[i].Religion;
                     uprofile.upgenderLabel.Text = list[i].Gender;
                     uprofile.uplastdateLabel.Text = list[i].LastDateOfBloodDonatin;
                     uprofile.updivisionLabel.Text = list[i].Division;
                     uprofile.uplarealabel.Text = list[i].Area;

                    
                 }
		     }


            
            //this.Close();
        }

        private void userPasswordTextBox_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            homepage.Show();
            this.Close();
        }
    }
}
