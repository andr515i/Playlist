using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist
{
    class Program
    {

        static void Main(string[] args)
        {  // i have no brain power left so i apologize to myself and whoever reads this
            // mass,  dia, density,  gravity,  rotationPeriod,  lod,  distanceSun,  oribtialPeriod,  orbitalVelocity,  meanTemp,  numberOfMoons,  name,  ringSystem


            //before lunch
            Planet Mercury = new Planet(.330, 3.7, 5427.0, 4222.6, 57.9, 1407.6, 88.0, 47.4, 1407.6, 167.0, 0.0, "Mercury", false);  // first i get all the planets and MANUALLY give it the data it needs
            Planet Earth = new Planet(5.97, 12756.0, 5514.0, 9.8, 24.0, 149.6, 365.2, 29.8, 23.9, 15.0, 1.0, "Earth", false);
            Planet Mars = new Planet(0.642, 6792.0, 3933.0, 3.7, 24.6, 24.7, 227.9, 687.0, 24.1, -65.0, 2.0, "Mars", false);
            Planet Venus = new Planet(4.87, 12104.0, 5243.0, 8.9, -5832.5, 2802.0, 108.2, 224.7, 35.0, 4640, 0.0, "Venus", false);
            Planet Jupiter = new Planet(0.642, 142984.0, 1326.0, 23.1, 9.9, 9.9, 778.6, 4331.0, 13.1, -110.0, 67.0, "Jupiter", true);
            Planet Saturn = new Planet(568.0, 120536.0, 687.0, 9.0, 10.7, 10.7, 1433.5, 10747.0, 9.7, -140.0, 62.0, "Saturn", true);
            Planet Uranus = new Planet(86.8, 51118.0, 1271.0, 8.7, -17.2, 17.2, 2872.5, 30589.0, 6.8, -195, 27.0, "Uranus", true);
            Planet Neptun = new Planet(102.0, 49528.0, 1638.0, 11.0, 16.1, 16.1, 4495.1, 59.0, 5.4, -200.0, 14.0, "Neptun", true);
            Planet Pluto = new Planet(0.0146, 2370.0, 2095.0, 0.7, -153.3, 153.3, 5906.4, 90.56, 4.7, -225.0, 5.0, "Pluto", false);
            //hide that please, someone
            //after lunch

            // then we add them all into a Planet list, specified through the worksheet given to me
            List<Planet> planets = new List<Planet>();
            planets.Add(Mercury);
            planets.Add(Earth);
            planets.Add(Mars);
            planets.Add(Jupiter);
            planets.Add(Saturn);
            planets.Add(Uranus);
            planets.Add(Neptun);
            planets.Add(Pluto);
            planets.Insert(1, Venus); // we originally dont put venus in, but it has to be iun the right place, which is right after mercury

            Console.WriteLine("-------------------------------------------");
            foreach (Planet planet in planets)  //loop through all Planets in planets list
            {
                Console.WriteLine(planet.planetName);// we print out the names of all the planets, luckily all in order
            }

            // now we remove pluto as pluto is a dwardplanet, and not a regular planet
            for (int i = 0; i < planets.Count; i++)
            {
                if (i == planets.IndexOf(Pluto))  // indexof gives the index of the first occurance of given object
                {
                    planets.RemoveAt(i); // then we remove whatever is at that index
                }
            }
            Console.WriteLine("-------------------------------------------");
            foreach (Planet planet in planets)  //loop through all Planets in planets list
            {
                Console.WriteLine(planet.planetName);// we print out the names of all the planets
            }
            Console.WriteLine("-------------------------------------------");
            // we actually dont want to remove pluto because we like pluto
            planets.Add(Pluto); //we can just use add as pluto was already the last element and will continue to be
            Console.WriteLine("total amount of planets: " + planets.Count);  // 9 planets, which is true, however we mighht get fooled by the console, which last printed the list without pluto
            List<Planet> lowTempPlanets = new List<Planet>();
            // now  we make a new list only with those planets that have a mean temp below 0
            foreach (Planet planet in planets)  //loop through all Planets in planets list
            {
                if (planet.meanTemperature < 0)  // check for meantemp on every planet 
                {
                    lowTempPlanets.Add(planet); // add planet into new array
                }

            }
            Console.WriteLine("-------------------------------------------");
            // loop through all low temp planets and print them out
            foreach (Planet planet in lowTempPlanets)
            {
                Console.WriteLine(planet.planetName);
            }
            Console.WriteLine("-------------------------------------------");
            // now we do the same but for planets with diameters between 10000 and 50000
            List<Planet> diameterPlanetList = new List<Planet>();
            foreach (Planet planet in planets)  //loop through all Planets in planets list
            {
                if (planet.diameter > 10000 && planet.diameter < 50000)
                {
                    diameterPlanetList.Add(planet);
                }
            }
            foreach (Planet planet in diameterPlanetList)
            {
                Console.WriteLine(planet.planetName);
            }
            Console.WriteLine("-------------------------------------------");
        }
    }
}
