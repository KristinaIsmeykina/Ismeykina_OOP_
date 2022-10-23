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
        /// <summary>
        /// Current checked RadioButton
        /// </summary>
        private RadioButton CheckedRadioButton { get; set; }
        public InputForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {

        }


        private void ParallelepipedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.parallelepipedUserControl.Visible = ParallelepipedRadioButton.Checked;

        }

        private void PyramidRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            this.pyramidUserControl.Visible = PyramidRadioButton.Checked;
        }

        private void SphereRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.sphereUserControl.Visible = SphereRadioButton.Checked;
        }
    }
}