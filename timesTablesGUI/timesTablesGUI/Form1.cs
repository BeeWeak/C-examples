using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timesTablesGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int timesTables;

            timesTables = int.Parse(txtNumber.Text);

            txtTimesTables.Text = "";
            for (int i = 1; i <= 10; i++)
            {
                txtTimesTables.Text = txtTimesTables.Text + i * timesTables + Environment.NewLine;
            }
        }
    }
}
