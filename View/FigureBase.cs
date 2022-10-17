using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class FigureBase
    {
        protected static void CheckValue(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    $"The value must be greater than 0");
            }
        }

        protected abstract double GetVolume();
        protected abstract string Info { get; }

    }
}
