using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            CarLot sawyerCarLot = new CarLot();

            

            //Object Initializer
            Car currentCar = new Car()
            {
                Make = "Chevrolet",
                Year = 2015,
                Model = "Silverado",
                IsDrivable = true,
                EngineNoise = "Vroom",
                HonkNoise = "Honk",
            };
            currentCar.MakeEngineNoise();
            currentCar.MakeHonkNoise();

            sawyerCarLot.ListOfCars.Add(currentCar);

            //Dot Notation
            Car nextCar= new Car();
            nextCar.Make = "Chevrolet";
            nextCar.Year = 1969;
            nextCar.Model = "Camero";
            nextCar.IsDrivable = true;
            nextCar.EngineNoise = "VlomVlom";
            nextCar.HonkNoise = "BamphBamph";

            nextCar.MakeEngineNoise();
            nextCar.MakeHonkNoise();

            sawyerCarLot.ListOfCars.Add(nextCar);

            //Custom
            var oldCar = new Car(2003, "Nissan", "Pathfinder", "romrom", "beep beep", true);

            oldCar.MakeEngineNoise();
            oldCar.MakeHonkNoise();

            sawyerCarLot.ListOfCars.Add(oldCar);

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach (var currentcar in sawyerCarLot.ListOfCars)
            {
                Console.WriteLine();
                Console.WriteLine($"Year: {currentcar.Year}. Make: {currentcar.Make}. Model: {currentcar.Model}");
                Console.WriteLine();
            }
        }
    }
}
