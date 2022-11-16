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
    /// Класс Sphere UserControl
    /// </summary>
    public partial class SphereUserControl : FigureBaseUserControl
    {
        /// <summary>
        /// Конструктор Sphere UserControl
        /// </summary>
        public SphereUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// < inheritdoc />
        /// </summary>
        /// <returns></returns>
        public override FigureBase GetFigur
        {
            get
            {
                var newSphere = new Sphere
                {
                    Radius = Convert.ToDouble(RadiusTextBox.Text)
                };

                return newSphere;
            }
        }
    }
}
