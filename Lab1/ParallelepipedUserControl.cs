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
            //Action actionReadHeight = () =>
            //{
            //    newParallelepiped.Height = Convert.ToDouble(HeightTextBox.Text);
            //};
            //ActionHandler(actionReadHeight);
            //Action actionReadFirstSide = () =>
            //{
            //    newParallelepiped.FirstSide = Convert.ToDouble(FirstSideTextBox.Text);
            //};
            //ActionHandler(actionReadFirstSide);
            //Action actionReadSecondSide = () =>
            //{
            //    newParallelepiped.SecondSide = Convert.ToDouble(SecondSideTextBox.Text);
            //};
            //ActionHandler(actionReadSecondSide);
            //Action actionReadAngle = () =>
            //{
            //    newParallelepiped.Angle = Convert.ToDouble(AngleOfSidesTextBox.Text);
            //};
            //ActionHandler(actionReadAngle);
            //return newParallelepiped;

            var actions = new List<Action>()
            {
                () =>
                {
                    newParallelepiped.Height = Convert.ToDouble(HeightTextBox.Text);
                },

                () =>
                {
                    newParallelepiped.FirstSide = Convert.ToDouble(FirstSideTextBox.Text);
                },

                () =>
                {
                    newParallelepiped.SecondSide = Convert.ToDouble(SecondSideTextBox.Text);
                },

                () =>
                {
                    newParallelepiped.Angle= Convert.ToDouble(AngleOfSidesTextBox.Text);
                },
            };

            foreach (var action in actions)
            {
                action.Invoke();
            }

            return newParallelepiped;
        }


        //private static void ActionHandler(Action action)
        //{
        //    while (true)
        //    {
        //        try
        //        {
        //            action.Invoke();
        //            return;
        //        }
        //        catch (Exception e)
        //        {
        //            if (e is ArgumentException || e is FormatException)
        //            {
        //                Console.WriteLine(e.Message);
        //                Console.WriteLine("Try again!");
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //    }
        //}


    }
}
