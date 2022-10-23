using Model;
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
        /// Figure
        /// </summary>
        private FigureBase FigureBase { get; set; }
        /// <summary>
        /// Current checked RadioButton
        /// </summary>
        private RadioButton CheckedRadioButton { get; set; }

        //private List<RadioButton> radioButtons = new List<RadioButton> { ParallelepipedRadioButton }
        //;

        public InputForm()
        {
            InitializeComponent();
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
           

            if (CheckedRadioButton.Equals(ParallelepipedRadioButton))
            {
                var newParallelepiped = new Parallelepiped();
                FigureBase =  ParallelepipedUserControl.GetParallelepiped();
            }

        }


        private void ParallelepipedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.parallelepipedUserControl.Visible = ParallelepipedRadioButton.Checked;
            CheckedRadioButton = ParallelepipedRadioButton;

        }

        private void PyramidRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            this.pyramidUserControl.Visible = PyramidRadioButton.Checked;
            CheckedRadioButton = PyramidRadioButton;
        }

        private void SphereRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.sphereUserControl.Visible = SphereRadioButton.Checked;
            CheckedRadioButton = SphereRadioButton;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}