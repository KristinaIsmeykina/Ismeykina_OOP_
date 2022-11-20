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
        //TODO: В свойство +++.
        /// <summary>
        /// Метод для получения фигуры
        /// </summary>
        /// <returns></returns>
        public abstract FigureBase GetFigur { get; }

        /// <summary>
        /// Метод для проверки строки
        /// </summary>
        /// <param name="value">строка для проверки</param>
        /// <param name="errorMessage">полученная ошибка</param>
        /// <returns></returns>
        public bool IsValidValue(string value, out string errorMessage)
        {
            if (string.IsNullOrEmpty(value))
            {
                errorMessage = "Empty value";
                return false;
            }

            if (value.Contains('.'))
            {
                errorMessage = "Incorrect format. Maybe expected ','";
                return false;
            }

            if (double.TryParse(value, out var tmpValue))
            {
                if (tmpValue > 0)
                {
                    errorMessage = "";
                    return true;
                }

                errorMessage = "Value must be positive";
                return false;
            }

            errorMessage = "Value must be an integer of decimal number";
            return false;
        }
    }
}
