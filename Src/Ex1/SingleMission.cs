using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Excercise_1
{

    /// <summary>Encapsulates a single mission function</summary>
    class SingleMission : IMission
    {

        /// <summary>The mission</summary>
        Function<double, double> mission;

        /// <summary>Occurs when [on calculate].</summary>
        public event EventHandler<double> OnCalculate;

        /// <summary>Initializes a new instance of the <see cref="SingleMission"/> class.</summary>
        /// <param name="func">The function.</param>
        /// <param name="name">The name.</param>
        public SingleMission(Function<double,double> func, string name)
        {
            mission = func;
            Name = name;
            Type = "Single";
        }

        /// <summary>Gets the name.</summary>
        /// <value>The name.</value>
        public String Name { get; }

        /// <summary>Gets the type.</summary>
        /// <value>The type.</value>
        public String Type { get; }


        /// <summary>Calculates the specified value.</summary>
        /// <param name="value">The value.</param>
        /// <returns>The calculated value</returns>
        public double Calculate(double value)
        {
            // Calcualte
            double val = mission(value);
            // Invoke event
            OnCalculate?.Invoke(this, val);
            return val;
        }

    }

}
