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
    //TODO: XML ++
    /// <summary>
    /// Класс Pyramid UserControl
    /// </summary>
    public partial class PyramidUserControl : FigureBaseUserControl
    {

        /// <summary>
        /// Конструктор класса Parallelepiped UserControl
        /// </summary>
        public PyramidUserControl()
        {
            InitializeComponent();
            HeightTextBox.TextChanged += TextBox_TextChanged;
            FirstSideTextBox.TextChanged += TextBox_TextChanged;
            SecondSideTextBox.TextChanged += TextBox_TextChanged;
            AngleOfSidesTextBox.TextChanged += TextBox_TextChanged;
            NumberOfCornersComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //TODO: XML++
        ///< inheritdoc />
        public override FigureBase GetFigur
        {
            get
            {
                var newPyramid = new Pyramid
                {
                    Height = Convert.ToDouble(HeightTextBox.Text),

                    FirstSide = Convert.ToDouble(FirstSideTextBox.Text),

                    SecondSide = Convert.ToDouble(SecondSideTextBox.Text),

                    Angle = Convert.ToDouble(AngleOfSidesTextBox.Text),
                    NumberOfCorners = Convert.ToInt32(NumberOfCornersComboBox.Text)
                };
                return newPyramid;
            }
        }

        /// <summary>
        /// Событие при изменении TextBox
        /// </summary>
        /// <param name="sender"> </param>
        /// <param name="e"></param>
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;

            IsValidValue(textBox.Text, out var errorMsg);
            errorProvider1.SetError(textBox, errorMsg);
        }
    }
}
