using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    /// <summary>Mission Interface</summary>
    interface IMission
    {
        /// <summary>Occurs when [on calculate].</summary>
        event EventHandler<double> OnCalculate;  // An Event of when a mission is activated

        /// <summary>Gets the name.</summary>
        /// <value>The name.</value>
        String Name { get; }

        /// <summary>Gets the type.</summary>
        /// <value>The type.</value>
        String Type { get; }

        /// <summary>Calculates the specified value.</summary>
        /// <param name="value">The value.</param>
        /// <returns>The calculated value</returns>
        double Calculate(double value);
    }
}
