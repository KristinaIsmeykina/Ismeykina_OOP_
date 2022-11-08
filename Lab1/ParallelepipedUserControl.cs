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
        }
        /// <summary>
        ///< inheritdoc />
        /// </summary>
        /// <returns></returns>
        public override FigureBase GetFigur()
        {
            var newParallelepiped = new Parallelepiped
            {
                Height = Convert.ToDouble(HeightTextBox.Text),
                FirstSide = Convert.ToDouble(FirstSideTextBox.Text),
                SecondSide = Convert.ToDouble(SecondSideTextBox.Text),
                Angle = Convert.ToDouble(AngleOfSidesTextBox.Text)
            };

            return newParallelepiped;
        }

    }
}
