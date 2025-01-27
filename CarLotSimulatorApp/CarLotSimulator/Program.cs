﻿using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot Lot = new CarLot();
            //Standard Member initialization
            Car Truck = new Car();

           
            Lot.Cars.Add(Truck);
            Truck.Make = "GMC";
            Truck.Model = "Denali";
            Truck.Year = 2021;
            Truck.EngineNoise = "Vrooom Vroom!";
            Truck.HonkNoise = "Hooooonk!";
            Truck.IsDrivable = true;
            Truck.MakeEngineNoise();
            Truck.MakeHonkNoise();
            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            //Object initializar syntax
            Car SportsFord = new Car() { Make = "Raptor", Model = "Ford", Year = 2021, EngineNoise = "Vroooommm!", HonkNoise = "Choo Choo", IsDrivable = true };
            Lot.Cars.Add(SportsFord);

          

            SportsFord.MakeEngineNoise();
            SportsFord.MakeHonkNoise();
            //*************BONUS*************//
            //Constructor initialization 
            Car ColoradoCar = new Car("Subaru", "Forester", 2020, "Vram!", "BeeP!", true);
            Lot.Cars.Add(ColoradoCar);

           

            ColoradoCar.MakeEngineNoise();
            ColoradoCar.MakeHonkNoise();
            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            Console.WriteLine("-------------------------------");
            //*************BONUS X 2*************//
           
            //Console.WriteLine("---------------------------------------");
            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Car sportsCar = new Car() { Year = 2021, Make = "Ferrari", Model = "Mondial", EngineNoise = "Fast Fast", HonkNoise = "Bongg Bongg", IsDrivable = true };
            Lot.Cars.Add(sportsCar);

            

            Car smartCar = new Car() { Year = 2020, Make = "Smart Car", Model = "For Two" };
          
            Lot.Cars.Add(smartCar);

            Car electricCar = new Car() { Year = 2021, Make = "Tesla", Model = "Model X" };
           
            Lot.Cars.Add(electricCar);

            foreach (var car in Lot.Cars)
            {
                Console.WriteLine($"Make: {car.Make}, Model: {car.Model}, Year: {car.Year}");
            }
            Console.WriteLine(CarLot.numberOfCars);


        }
    }
}
