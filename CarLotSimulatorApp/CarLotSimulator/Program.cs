using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
 
        {
            var lot = new CarLot();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            var ZachsCar = new Car();

            ZachsCar.Make = "Hyundai";
            ZachsCar.Year = 2024;
            ZachsCar.IsDriveable = true;
            ZachsCar.HonkNoise = "Balooga";
            ZachsCar.EngineNoise = "Vrooom";
            ZachsCar.Model = "Sante Fe";

            lot.Cars.Add(ZachsCar);

            //Object Initializer Syntax
            var ZacharisCar = new Car()
            {
                Year = 2023,
                Make = "Tesla",
                Model = "Cyber Truck",
                HonkNoise = "Tetete",
                EngineNoise = "Swoosh",
                IsDriveable = true,


            };

            lot.Cars.Add(ZacharisCar);

            // Using the constructor to allow parameter values to be placed inside properties
            var nemisCar = new Car(2038, "BMW", "350", "HonkHonk", "Yeeeeurm", true);

            lot.Cars.Add(nemisCar);

            //Call methods
            nemisCar.ModelOfVehicle(nemisCar.Model);
            nemisCar.MakeEngineNOise(nemisCar.EngineNoise);
            nemisCar.CanItStart(nemisCar.IsDriveable);
            nemisCar.MakeHonkNoise(nemisCar.HonkNoise);
            nemisCar.YearOfProduction(nemisCar.Year);
            nemisCar.MakeOfVehicle(nemisCar.Model);

            Console.WriteLine();

          
            ZacharisCar.ModelOfVehicle(ZacharisCar.Model);
            ZacharisCar.MakeEngineNOise(ZacharisCar.EngineNoise);
            ZacharisCar.CanItStart(ZacharisCar.IsDriveable);
            ZacharisCar.MakeHonkNoise(ZacharisCar.HonkNoise);
            ZacharisCar.YearOfProduction(ZacharisCar.Year);
            ZacharisCar.MakeOfVehicle(ZacharisCar.Model);

            Console.WriteLine();

            ZachsCar.ModelOfVehicle(ZachsCar.Model);
            ZachsCar.MakeEngineNOise(ZacharisCar.EngineNoise);
            ZachsCar.CanItStart(ZachsCar.IsDriveable);
            ZachsCar.MakeHonkNoise(ZachsCar.HonkNoise);
            ZachsCar.YearOfProduction(ZachsCar.Year);
            ZachsCar.MakeOfVehicle(ZachsCar.Model);



            Console.WriteLine();


            



            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
        }

    }
}
