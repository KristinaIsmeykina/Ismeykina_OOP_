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
    /// <summary>
    /// Класс Parallelepiped UserControl
    /// </summary>
    public partial class ParallelepipedUserControl : FigureBaseUserControl
    {
        /// <summary>
        /// Конструктор класса Parallelepiped UserControl
        /// </summary>
        public ParallelepipedUserControl()
        {
            InitializeComponent();
            HeightTextBox.KeyPress += TextBox_KeyPress;
            FirstSideTextBox.KeyPress += TextBox_KeyPress;
            SecondSideTextBox.KeyPress += TextBox_KeyPress;
            AngleOfSidesTextBox.KeyPress += TextBox_KeyPress;
        }
        /// <summary>
        ///< inheritdoc />
        /// </summary>
        /// <returns></returns>
        public override FigureBase GetFigur
        {
           
        get

            {
                    var newParallelepiped = new Parallelepiped()
                    {

                        Height = Convert.ToDouble(HeightTextBox.Text),
                        FirstSide = Convert.ToDouble(FirstSideTextBox.Text),
                        SecondSide = Convert.ToDouble(SecondSideTextBox.Text),
                        Angle = Convert.ToDouble(AngleOfSidesTextBox.Text)
                    };
                    return newParallelepiped;
            }
        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
        // private string CheckValue2(string value, string text)
        //{
        //    string stroka = "";
        //    if (value <= 0)
        //    {
        //        stroka += "The value must be greater than 0";
        //    }
        //    return text += stroka;
        //}
        //private string CheckValueAll()
        //{
        //    string text = "";
        //    text += CheckValue2(HeightTextBox.Text, "Поле высота");
        //    text += CheckValue2(FirstSideTextBox.Text, "Поле первая сторона");
        //    text += CheckValue2(SecondSideTextBox.Text, "Поле вторая высота");
        //    text += CheckValue2(AngleOfSidesTextBox.Text, "Поле угол");
        //    return text;
        //}
    }
}
