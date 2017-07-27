using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Name: Fuad Mannan
 * Date: July 27, 2017
 * Description: This is the Abstract Planet class
 * Version: 0.2 - Added private instance variables, properties, constructor, ToString
 */

namespace Assignment4
{
    /// <summary>
    /// This is the Abstract Planet Class
    /// </summary>
    public abstract class Planet
    {
        // Private Instance Variables
        private double _diameter, _mass, _orbitalPeriod, _rotationalPeriod;
        private int _moonCount, _ringCount;
        private string _name;

        // Public Properties
        public double Diameter { get; }
        public double Mass { get; }
        public int MoonCount { get; set; }
        public string Name { get; }
        public double OrbitalPeriod { get; set; }
        public int RingCount { get; set; }
        public double MyProperty { get; set; }

        // Constructor
        public Planet(string name,double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }

        // ToString() Function
        public override string ToString()
        {
            return string.Format("Planet: {0}, Diameter: {1}, Mass: {2}", Name, Diameter, Mass);
        }
    }
}
