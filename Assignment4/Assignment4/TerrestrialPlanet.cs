using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Name: Fuad Mannan
 * Date: July 27, 2017
 * Description: This is the TerrestrialPlanet class
 * Version: 0.2 - Implemented interfaces
 */

namespace Assignment4
{
    public class TerrestrialPlanet : Planet, IHabitable, IHasMoons
    {
        //Private Instance Variale
        private bool _oxygen;

        //Constructor
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }

        //Public Methods
        public bool HasMoons()
        {
            return (MoonCount > 0);
        }
        public bool Habitable()
        {
            return (this._oxygen);
        }
    }
}
