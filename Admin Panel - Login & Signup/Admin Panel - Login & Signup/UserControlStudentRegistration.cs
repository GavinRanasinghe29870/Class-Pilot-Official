using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Class_Pilot
{
    public partial class UserControlStudentRegistration : UserControl
    {
        string server = "localhost";
        string uid = "root";
        string password = "";
        string database = "class_pilot";
        public UserControlStudentRegistration()
        {
            InitializeComponent();

        }

        private void UserControlStudentRegistration_Load(object sender, EventArgs e)
        {
            this.Hide();
            GetStudentID();
            txtImageLocation.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            }
        }

       

        private void rbtnstdMale_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbtnstdFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnChImage_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtstdFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    
}
