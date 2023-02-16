using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car() 
        {
            CarLot.numberOfCars++;
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }



        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDrivable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDrivable = isDrivable;

            CarLot.numberOfCars++;
        }


        public void MakeEngineNoise()
        { 
            Console.WriteLine($"The {Model} needs some work under the hood. Its makeing a {EngineNoise} noise."); 
        }
        public void MakeHonkNoise() 
        {
            Console.WriteLine($"The {Make}'s horn might be broken. It sounds like {HonkNoise}."); 
        }
    }
}
