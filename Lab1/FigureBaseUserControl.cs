using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    /// <summary>
    /// Класс FigureBase UserControl
    /// </summary>
    public abstract partial class FigureBaseUserControl : UserControl
    {
        //TODO: В свойство.
        /// <summary>
        /// Метод для получения фигуры
        /// </summary>
        /// <returns></returns>
        public abstract FigureBase GetFigur();
    }
}
