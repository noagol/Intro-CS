using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Excercise_1
{

    /// <summary>
    /// stores a concatenation of functions among the functions 
    /// Which are stored in the FunctionsContainer class
    /// </summary>
    /// <seealso cref="Excercise_1.IMission" />
    class ComposedMission : IMission
    {

        /// <summary>The missions</summary>
        List<Function<double,double>> missions;
        /// <summary>Occurs when [on calculate].</summary>
        public event EventHandler<double> OnCalculate;


        /// <summary>Initializes a new instance of the <see cref="ComposedMission"/> class.</summary>
        /// <param name="name">The name.</param>
        public ComposedMission(String name)
        {
            missions = new List<Function<double, double>>();
            Name = name;
            Type = "Composed";
        }

        /// <summary>Gets the name.</summary>
        /// <value>The name.</value>
        public String Name { get; }

        /// <summary>Gets the type.</summary>
        /// <value>The type.</value>
        public String Type { get; }


        /// <summary>Adds the specified function.</summary>
        /// <param name="func">The function.</param>
        /// <returns>the mission</returns>
        public ComposedMission Add(Function<double, double> func)
        {
            missions.Add(func);
            return this;
        }

        /// <summary>Calculates the specified value.</summary>
        /// <param name="value">The value.</param>
        /// <returns>The calculated value.</returns>
        public double Calculate(double value)
        {
            //goes all mission
            foreach (var func in missions)
            {
                value = func(value);
            }
            OnCalculate?.Invoke(this, value);
            return value;
        }
    }
}
