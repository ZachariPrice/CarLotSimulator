using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {

        public Car()
        {
            CarLot.numberOfCars++;
            // ^^^^^^^^^^^^^^^^^
            // ClassName.StaticNumber 
        }

        public Car(int year, 
                   string make, 
                   string model, 
                   string engineNoise, 
                   string honkNoise, 
                   bool isDrivable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDrivable;
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNOise(string engineNoise)
        {
            Console.WriteLine(engineNoise);
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine(honkNoise);
        }

        public void ModelOfVehicle(string model)
        { 
            Console.WriteLine(model);

        }

        public void YearOfProduction(int Year)
        {
            Console.WriteLine(Year);
        }

        public void CanItStart(bool IsDriveable)
        {
            Console.WriteLine(IsDriveable);

        }

        public void MakeOfVehicle(string Make)
        {
            Console.WriteLine(Make);
        }

        // Other methods

        // public string MakeofVehicle()
        // {
        //    return EngineNoise;
        // }



    }
}
