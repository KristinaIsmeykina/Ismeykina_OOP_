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
    public partial class ParallelepipedUserControl : UserControl
    {
        public ParallelepipedUserControl()
        {
            InitializeComponent();
        }
        public  Parallelepiped GetParallelepiped()
        {
            var newParallelepiped = new Parallelepiped();

            newParallelepiped.Height = Convert.ToDouble(HeightTextBox.Text);

            newParallelepiped.FirstSide = Convert.ToDouble(FirstSideTextBox.Text);

            newParallelepiped.SecondSide = Convert.ToDouble(SecondSideTextBox.Text);

            newParallelepiped.Angle = Convert.ToDouble(AngleOfSidesTextBox.Text);
            return newParallelepiped;


        }



    }
}
