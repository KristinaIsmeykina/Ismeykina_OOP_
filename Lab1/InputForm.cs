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
        public double r;
        /// <summary>
        /// Figure
        /// </summary>
        public FigureBase FigureBase { get; set; }
       
        /// <summary>
        /// Current checked RadioButton
        /// </summary>
        private RadioButton CheckedRadioButton { get; set; }

        /// <summary>
        /// Dictionary of RadioButton to it's UserControl
        /// </summary>
        private readonly Dictionary<RadioButton, UserControl> _radioButtonToUserControl;
        public InputForm()
        {
            InitializeComponent();
            SphereRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            PyramidRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            ParallelepipedRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            _radioButtonToUserControl = new Dictionary<RadioButton, UserControl>()
            {
                {SphereRadioButton, sphereUserControl},
                {PyramidRadioButton, pyramidUserControl},
                {ParallelepipedRadioButton, parallelepipedUserControl}
            };
        }
        private void OkButton_Click(object sender, EventArgs e)
        {

            try
            {

                if (CheckedRadioButton.Equals(ParallelepipedRadioButton))
                {
                    var newForm = new ParallelepipedUserControl();
                    FigureBase = newForm.GetParallelepiped();
                }
                if (CheckedRadioButton.Equals(PyramidRadioButton))
                {

                    var newForm = new PyramidUserControl();
                    FigureBase = newForm.GetPyramid();
                }
                if (CheckedRadioButton.Equals(SphereRadioButton))
                {

                    var newForm = new SphereUserControl();
                    FigureBase = newForm.GetSphere();
                }
                DialogResult = DialogResult.OK;
            }

            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            //if (CheckedRadioButton.Equals(SphereRadioButton))
            //{
            //    var newForm = new SphereUserControl();
            //    r = newForm.GetSphere();
            //}
            //MessageBox.Show(r.ToString());

        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {

            var Sn = SelectFigureGroupBox.Controls.OfType<RadioButton>().ToList();

            foreach (RadioButton i in Sn)
            {
                _radioButtonToUserControl[i].Visible = i.Checked;
                if (i.Checked)
                {
                    _radioButtonToUserControl[i].Visible = i.Checked;
                    CheckedRadioButton = i;
                }
            }
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}