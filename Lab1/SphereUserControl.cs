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
    public partial class SphereUserControl : UserControl
    {
        public SphereUserControl()
        {
            InitializeComponent();
        }
        //public Sphere GetSphere()
        //{
        //    var newSphere = new Sphere();
        //    var actions = new List<Action>()
        //    {
        //        () =>
        //        {
        //            newSphere.Radius = Convert.ToDouble(RadiusTextBox.Text);
        //        }
        //    };

        //    foreach (var action in actions)
        //    {
        //        action.Invoke();
        //    }
        //    return newSphere;
        //}
    }
}
