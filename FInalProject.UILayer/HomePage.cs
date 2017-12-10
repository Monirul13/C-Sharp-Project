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
    public partial class Home_Page : MetroForm
    {
        List<UserInfo> lst = new List<UserInfo>();


        public Home_Page()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void goButton_Click(object sender, EventArgs e)
        {
            ResultUI resultUI = new ResultUI(this);
            UserData ud = new UserData();
            resultUI.Show();
            
            string str = bgroupBox.Text;
            string str2 = selectDivisionBox.Text;
            
            lst=ud.GetUserList(str, str2);
            resultUI.resultdataGridView.DataSource = lst;
            this.Hide();

           MessageBox.Show("Wait a moment......");

           

            
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
             UserAccount userAccount = new UserAccount(this);
             userAccount.Show();
             this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Create_Account createAccount = new Create_Account(this);
            createAccount.Show();
            this.Hide();
        }
    }
}
