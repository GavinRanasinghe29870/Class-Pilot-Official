using Class_Pilot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Pilot
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnadmPayments_Click(object sender, EventArgs e)
        {
            Side_Menu payments = new Side_Menu();
            payments.Show();
            this.Hide();
            
        }

        private void btnadmAttendence_Click(object sender, EventArgs e)
        {
            Side_Menu attendence = new Side_Menu();
            attendence.Show();
            this.Hide();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
        }
        
        private void btnadmCreateClass_Click(object sender, EventArgs e)
        {
           Side_Menu CreateClass = new Side_Menu();   
            CreateClass.Show();
            this.Hide();
        }

        private void btnadmStdRegister_Click(object sender, EventArgs e)
        {
            Side_Menu StdRegistration = new Side_Menu();
            StdRegistration.Show();
            this.Hide();
        }

        private void btnadmReports_Click(object sender, EventArgs e)
        {
            Side_Menu Reports = new Side_Menu();
            Reports.Show();
            this.Hide();
        }

        private void btnadmTchEdits_Click(object sender, EventArgs e)
        {
            Side_Menu TchEdits = new Side_Menu();
            TchEdits.Show();
            this.Hide();
        }

        private void btnadmstdEdits_Click(object sender, EventArgs e)
        {
            Side_Menu stdEdits = new Side_Menu();
            stdEdits.Show();
            this.Hide();
        }

        private void btnadmClassEdits_Click(object sender, EventArgs e)
        {
            Side_Menu ClassEdits = new Side_Menu();
            ClassEdits.Show();
            this.Hide();
        }
    }
}
