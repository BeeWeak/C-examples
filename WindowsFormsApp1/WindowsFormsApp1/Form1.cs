using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private void btnGreeting_Click(object sender, EventArgs e)
        {
            string name;
            name = txtName.Text;

            MessageBox.Show("Hello " + name);
        }

        private void btnGreeting_Click_1(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
