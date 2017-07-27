using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Name: Fuad Mannan
 * Date: July 27, 2017
 * Description: This is the GiantPlanet class
 * Version: 0.3 - Updated formatting
 */

namespace Assignment4
{
    public class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        //Private Instance Variables
        private string _type;

        //Constructor
        public GiantPlanet(string name, double diameter, double mass, string type)
            : base(name, diameter, mass)
        {
            this._type = type;
        }

        //Public Methods
        public bool HasMoons()
        {
            return (MoonCount > 0);
        }
        public bool HasRings()
        {
            return (RingCount > 0);
        }
    }
}
