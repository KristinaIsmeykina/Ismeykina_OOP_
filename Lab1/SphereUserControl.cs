﻿using Model;
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
        public Sphere GetSphere()
        {
            var newSphere = new Sphere();

             newSphere.Radius = Convert.ToDouble(RadiusTextBox.Text);
            
            return newSphere;

        }
    }
}
