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
            RadiusTextBox.TextChanged += TextBox_TextChanged;
        }
        
        /// < inheritdoc />
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

        /// <summary>
        /// Событие при изменении TextBox
        /// </summary>
        /// <param name="sender">TextBox</param>
        /// <param name="e">данные события</param>
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;

            IsValidValue(textBox.Text, out var errorMsg);
            errorProvider1.SetError(textBox, errorMsg);
        }
    }
}
