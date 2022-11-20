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
        /// Свойство TextBox для валидации
        /// </summary>
        public bool IsValidTextBox { get; private set; }


        /// <summary>
        /// Конструктор класса Parallelepiped UserControl
        /// </summary>
        public ParallelepipedUserControl()
        {
            InitializeComponent();
            HeightTextBox.TextChanged+=TextBox_TextChanged;
            FirstSideTextBox.TextChanged += TextBox_TextChanged;
            SecondSideTextBox.TextChanged += TextBox_TextChanged;
            AngleOfSidesTextBox.TextChanged += TextBox_TextChanged;
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

        /// <summary>
        /// Событие при изменении TextBox
        /// </summary>
        /// <param name="sender">TextBox</param>
        /// <param name="e">lданные события</param>
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;

           IsValidTextBox = IsValidValue(textBox.Text, out var errorMsg);
            errorProvider1.SetError(textBox, errorMsg);
        }

        
        
    }
}
