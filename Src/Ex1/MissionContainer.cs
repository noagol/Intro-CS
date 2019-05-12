using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{

    /// <summary>delegate Function gets single argument</summary>
    /// <typeparam name="Input">The type of the input val.</typeparam>
    /// <typeparam name="Output">The type of the output val.</typeparam>
    /// <param name="input">The arg.</param>
    /// <returns> the Output value</returns>
    public delegate Output Function<Input, Output>(Input input);

    /// <summary>contains an INDEXER given a function name and Returns 
    /// an action that accepts and returns a single value</summary>
    public class FunctionsContainer
    {

        /// <summary>The function container</summary>
        Dictionary<String, Function<double, double>> funcContainer;

        /// <summary>Initializes a new instance of the <see cref="FunctionsContainer"/> class.</summary>
        public FunctionsContainer()
        {
            funcContainer = new Dictionary<string, Function<double, double>>();
        }

        /// <summary>Gets or sets the <see cref="Func{System.Double, System.Double}"/> with the specified index.</summary>
        /// <param name="idx">The index.</param>
        /// <value>The <see cref="Function{System.Double, System.Double}"/>.</value>
        public Function<double, double> this[String idx]
        {

            get
            {
                if (funcContainer.ContainsKey(idx))
                {
                    // Already in map - return it
                    return funcContainer[idx];
                }

                // Create trivial function
                funcContainer[idx] = val => val;

                return funcContainer[idx];
            }
            set
            {
                funcContainer[idx] = value;
            }
        }

        /// <summary>Gets all missions.</summary>
        /// <returns>A list of keys of the missions</returns>
        public List<String> getAllMissions()
        {
            return funcContainer.Keys.ToList();
        }

    }
}
