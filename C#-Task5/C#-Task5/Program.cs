﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace C__Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1  
            //Car fordCar = new Car();
            //fordCar.Make = "Ford";
            //fordCar.Year = 2022;
            //fordCar.Type = "Sedan";
            //fordCar.Price = 25000m;
            //fordCar.Model = "Fusion";
            //fordCar.PalletNo = "XYZ789";
            //fordCar.Color = "Blue";


            //Q2 use constructor 
            Car fordCar = new Car("Ford", 2022, "Sedan", 25000m, "Fusion", "XYZ789", "Blue");
          
            Console.WriteLine("Full Car Information:");
            fordCar.DisplayInfo(); 

            // Start the engine // For Q3
            fordCar.StartEngine();

            // Stop the engine // For Q3
            fordCar.StopEngine();

           
            //For Q6
            BMW bMW = new BMW("BMW", 2022, "Sedan", 30000m, "bmw", "XYZ789", "Black");
            Console.WriteLine(bMW.Year);
        }

    }


   
    public class Car
    {
        // Fields
        private string make;
        private int year;
        private string type;
        private decimal price;
        private string model;
        private string palletNo;
        private string color;
       // private bool isEngineRunning;//for Q3

        // Properties
        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value > 1885 && value <= DateTime.Now.Year) // Cars were invented after 1885
                    year = value;
                else
                    throw new ArgumentOutOfRangeException("Invalid year");
            }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                    price = value;
                else
                    throw new ArgumentOutOfRangeException("Price cannot be negative");
            }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string PalletNo
        {
            get { return palletNo; }
            set { palletNo = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        // Constructor 
        public Car(string make, int year, string type, decimal price, string model, string palletNo, string color)
        {
            Make = make;
            Year = year;
            Type = type;
            Price = price;
            Model = model;
            PalletNo = palletNo;
            Color = color;
            //isEngineRunning = false;//for Q3
        }



        // Method to display car information
        public void DisplayInfo()
        {
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Pallet No: {PalletNo}");
            Console.WriteLine($"Color: {Color}");
            //Console.WriteLine($"Engine Running: {isEngineRunning}");//for Q3
        }
        // Method to start //For Q3
        public void StartEngine()
        {
            Console.WriteLine("the car is starting");

        }
        // Method to stop //For Q3
        public void StopEngine()
        {
            Console.WriteLine("the car is stopping");
        }


       
    }

    //Q5
    class BMW : Car
    {


        public BMW(string make, int year, string type, decimal price, string model, string palletNo, string color) : base(make, year, type, price, model, palletNo, color)
        {

        }
    }





















}
