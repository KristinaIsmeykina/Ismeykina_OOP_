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
            Action actionReadHeight = () =>
            {
                newParallelepiped.Height = Convert.ToDouble(HeightTextBox.Text);
            };
            ActionHandler(actionReadHeight);
            Action actionReadFirstSide = () =>
            {
                newParallelepiped.FirstSide = Convert.ToDouble(FirstSideTextBox.Text);
            };
            ActionHandler(actionReadFirstSide);
            Action actionReadSecondSide = () =>
            {
                newParallelepiped.SecondSide = Convert.ToDouble(SecondSideTextBox.Text);
            };
            ActionHandler(actionReadSecondSide);
            Action actionReadAngle = () =>
            {
                newParallelepiped.Angle = Convert.ToDouble(AngleOfSidesTextBox.Text);
            };
            ActionHandler(actionReadAngle);

            return newParallelepiped;


        }


        private static void ActionHandler(Action action)
        {
            
                try
                {
                    action.Invoke();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error");
                }
            
        }


    }
}
