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
    public partial class ResultUI : MetroForm
    {
        Home_Page homepage;

        public ResultUI(Home_Page homepage)
        {
            InitializeComponent();
            this.homepage = homepage;
           
        }

        private void ResultUI_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Home_Page homePage = new Home_Page();
            homePage.Show();
            
            this.Close();
        }

        private void resultdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
    
            
        }
    }
}
