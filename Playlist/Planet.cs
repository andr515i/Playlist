using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist
{
    class Planet
    {
        //public double mass, diameter, gravity, rotationPeriod, lengthOfDay, distanceFromSun, oribtalPeriod, orbitalVelocity;
        //public int density, numberOfMOons;
        public double meanTemperature;
        public bool ringSystem;
        public string planetName;
        public double diameter;


        public Planet(double mass, double dia,double density, double gravity, double rotationPeriod, double lod, double distanceSun, double oribtialPeriod, double orbitalVelocity, double meanTemp, double numberOfMoons, string name, bool ringSystem)
        {
            List<double> information = new List<double>()
            {
                mass, dia, density, gravity, rotationPeriod, lod, distanceSun, oribtialPeriod, orbitalVelocity, meanTemp, numberOfMoons
            };
            this.planetName = name;
            this.ringSystem = ringSystem;
            this.meanTemperature = meanTemp;
            this.diameter = dia;
            Console.WriteLine("--- "+planetName+" ---");
            foreach (var info in information)
            {
                Console.WriteLine(info);
            }
            Console.WriteLine(ringSystem);
            
        }
        

    }
}
