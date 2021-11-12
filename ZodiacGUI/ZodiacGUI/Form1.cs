using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZodiacGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int yearBorn;

            yearBorn = int.Parse(txtYear.Text);

            txtOutput.Text = "";
            if (yearBorn == 2002)
            {
                txtOutput.Text = "Power, beauty, and freedom symbolize the horse in the Chinese culture. People born in the year of the horse are very high-spirited, active and energetic";
                flowLayoutPanel1.BackgroundImage = ZodiacGUI
            }
        }
    }
}
