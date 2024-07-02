using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task6
{
    internal class Program
    {

        public class Car
        {
            // Fields
            public string Make { get; set; }
            public int Year { get; set; }
            public string Type { get; set; }
            public decimal Price { get; set; }
            public string Model { get; set; }
            public string PalletNo { get; set; }
            public string Color { get; set; }

            //constructor 
            public Car ( string make, int year, string type, decimal price, string model, string palletNo, string color)
            {
                Make = make;
                Year = year;
                Type = type;
                Price = price;
                Model = model;
                PalletNo = palletNo;
                Color = color;

            }

            //the first function //Q2
            public void DisplayInfo(string make, int year)
            {
                if(Make==make&& Year == year)
                {
                    Console.WriteLine($"Make: {make}");
                    Console.WriteLine($"Year: {Year}");
                }

            }

            //The second function //Q3 (هون هاد السؤال لحتى نعرف انه منقدر نعمل نفس اسم الفنكشن بس لازم نغير نوع او عدد المتغيرات)
            public void DisplayInfo(string make)
            {
                if (Make == make )
                {
                    Console.WriteLine($"Make: {make}");
                  
                }

            }

             //The third function //Q4 
               public virtual void Display()
               {
                     Console.WriteLine("(Welcome Car)");
               }



        }

        //Make child class from Car class//Q5
       class BMW: Car
       {
            public BMW(string make, int year, string type, decimal price, string model, string palletNo, string color) : base(make, year, type, price, model, palletNo, color)
            {

            }
            public  override void Display ()
            { Console.WriteLine("(welcome BMW)"); }

        }






            static void Main(string[] args)
            {
            Car car1 = new Car("Toyota", 2020, "Sedan", 20000m, "Camry", "123ABC", "Red");
            car1.DisplayInfo("Toyota", 2020);
            car1.DisplayInfo("Toyota");
            car1.Display();


            BMW bmw = new BMW("BMW", 2022, "Sedan", 30000m, "bmw", "XYZ789", "Black");
            bmw.Display();



            }
    }
}
