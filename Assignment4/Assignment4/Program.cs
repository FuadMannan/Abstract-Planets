using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Name: Fuad Mannan
 * Date: July 27, 2017
 * Description: This is the "Driver" class
 * Version: 0.4 - Updated text
 */

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating *planet objects
            GiantPlanet giantPlanetObj = new GiantPlanet("Saturn", 2000, 2000, "Gas");
            TerrestrialPlanet terrestrialPlanetObj = new TerrestrialPlanet("Earth", 200, 200, true);
            Console.WriteLine("First Giant Planet - {0}", giantPlanetObj.ToString());
            Console.WriteLine("First Terrestrial Planet - {0}", terrestrialPlanetObj.ToString());
            WaitForAnyKey();
        }
        /// <summary>
        /// This is the WaitForAnyKey method, to wait for user input before exiting console
        /// </summary>
        static void WaitForAnyKey()
        {
            Console.Write("Press any key to exit");
            Console.ReadKey();
        }
    }
}
