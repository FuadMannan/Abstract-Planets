using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Name: Fuad Mannan
 * Date: July 27, 2017
 * Description: This is the Abstract Planet class
 * Version: 0.3 - Updated comments, formatting for readability
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

        public double Diameter
        {
            get { return this._diameter; }
        }

        public double Mass
        {
            get { return this._mass; }
        }

        public int MoonCount
        {
            get { return this._moonCount; }
            set { this._moonCount = value; }
        }

        public string Name
        {
            get { return this._name; }
        }

        public double OrbitalPeriod
        {
            get { return this._orbitalPeriod; }
            set { this._orbitalPeriod = value; }
        }

        public int RingCount
        {
            get { return this._ringCount; }
            set { this._ringCount = value; }
        }

        public double RotationalPeriod
        {
            get { return this._rotationalPeriod; }
            set { this._rotationalPeriod = value; }
        }

        // Constructor
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }

        /// <summary>
        /// ToString method for objects inheriting from Planet.
        /// Outputs name, diameter, mass.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Name: {0}, Diameter: {1}, Mass: {2}", Name, Diameter, Mass);
        }
    }
}
