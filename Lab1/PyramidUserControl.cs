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
    public partial class PyramidUserControl : FigureBaseUserControl
    {
        public PyramidUserControl()
        {
            InitializeComponent();
        }
        
        //public Pyramid GetPyramid()
        //{
        //    var newPyramid = new Pyramid();

        //    newPyramid.Height = Convert.ToDouble(HeightTextBox.Text);

        //    newPyramid.FirstSide = Convert.ToDouble(FirstSideTextBox.Text);

        //    newPyramid.SecondSide = Convert.ToDouble(SecondSideTextBox.Text);

        //    newPyramid.Angle = Convert.ToDouble(AngleOfSidesTextBox.Text);
        //    newPyramid.NumberOfCorners = Convert.ToInt32(NumberOfCornersComboBox.Text);
        //    return newPyramid;
        //}

        public override FigureBase GetFigur()
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
}
