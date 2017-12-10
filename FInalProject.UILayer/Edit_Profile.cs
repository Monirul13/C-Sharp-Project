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
    public partial class Edit_Profile : MetroForm
    {
        UserProfile uersProfile;

        public Edit_Profile(UserProfile uersProfile)
        {
            InitializeComponent();
            this.uersProfile = uersProfile;
        }

        private void Edit_Profile_Load(object sender, EventArgs e)
        {

        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            uersProfile.Show();
            this.Hide();
        }
    }
}
