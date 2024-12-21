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
    public partial class CreateClass : Form
    {
        
        private bool stdEditCollapsed;
        private const int AnimationIncrement = 10;
        private const int AnimationInterval = 5;

        public CreateClass()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StdTimer_Tick(object sender, EventArgs e)
        {
            if (stdEditCollapsed)
            {
                StdEditContainer.Height += 10;
                if (StdEditContainer.Height == StdEditContainer.MaximumSize.Height)
                {
                    stdEditCollapsed = false;
                    StdEditTimer.Stop();
                }
                else
                {
                    StdEditContainer.Height += 10;
                    if (StdEditContainer.Height == StdEditContainer.MinimumSize.Height)
                    {
                        stdEditCollapsed = true;
                        StdEditTimer.Stop();
                    }
                }
            }
            else
            {
                if (StdEditContainer.Height > StdEditContainer.MinimumSize.Height)
                {
                    StdEditContainer.Height -= AnimationIncrement;
                }
                else
                {
                    stdEditCollapsed = true;
                    StdEditTimer.Stop();
                }
            }
        }
        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            StdEditTimer.Start();
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }
    }     
}
