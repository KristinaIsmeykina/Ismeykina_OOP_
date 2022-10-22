using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
            if (radioButton1.Checked)
            {
                RadiusLabel.Visible = true;
                RadiusTextBox.Visible = true;

            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
