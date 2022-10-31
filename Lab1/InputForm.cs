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
        /// Свойство- фигура
        /// </summary>
        public FigureBase FigureBase { get; set; }
       
        /// <summary>
        /// Свойство- выбранный radiobutton
        /// </summary>
        private RadioButton CheckedRadioButton { get; set; }

        /// <summary>
        /// Словарь radiobutton- usercontrol
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
                    var newForm = (ParallelepipedUserControl)_radioButtonToUserControl[ParallelepipedRadioButton];
                    FigureBase = newForm.GetParallelepiped();
                }
                if (CheckedRadioButton.Equals(PyramidRadioButton))
                {

                    var newForm = (PyramidUserControl)_radioButtonToUserControl[PyramidRadioButton];
                    FigureBase = newForm.GetPyramid();
                }
                if (CheckedRadioButton.Equals(SphereRadioButton))
                {

                    var newForm = (SphereUserControl)_radioButtonToUserControl[SphereRadioButton];
                    FigureBase = newForm.GetSphere();
                }
                DialogResult = DialogResult.OK;
            }

            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }

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

        private void AddRandomFigureButton_Click(object sender, EventArgs e)
        {
            var random = new Random();
            var option = random.Next(3);
            switch (option)
            {
                case 0:
                    FigureBase=Sphere.GetRandomSphere();
                    break;
                case 1:
                    FigureBase=Pyramid.GetRandomPyramid();
                    break;
                case 2:
                    FigureBase=Parallelepiped.GetRandomParallelepiped();
                    break;
                default:
                    FigureBase= Parallelepiped.GetRandomParallelepiped();
                    break;
            }
            DialogResult = DialogResult.OK;
        }


    }
}