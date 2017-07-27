using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Name: Fuad Mannan
 * Date: July 27, 2017
 * Description: This is the "Driver" class
 * Version: 0.3 - Added planet objects to Main, created WaitForAnyKey method
 */

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanetObj = new GiantPlanet("Saturn", 2000, 2000,"Gas");
            Console.WriteLine("First Giant Planet: {0}",giantPlanetObj.ToString());
            TerrestrialPlanet terrestrialPlanetObj = new TerrestrialPlanet("Earth", 200, 200, true);
            Console.WriteLine("First Terrestrial Planet: {0}",terrestrialPlanetObj.ToString());
            WaitForAnyKey();
        }
        static void WaitForAnyKey()
        {
            Console.ReadKey();
        }
    }
}
