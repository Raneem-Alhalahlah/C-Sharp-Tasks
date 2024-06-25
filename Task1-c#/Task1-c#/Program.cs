

using System;
namespace Task1_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Quastion 1
            Console.WriteLine("Please enter your name:");
            string userInput = Console.ReadLine();
            Console.WriteLine("Your Name: " + userInput);


            //Qustion 2
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Qustion 2");
            
            double doubleNumber = 2.345;
            string stringText = "Raneem";
            char charText = 'M';
            int intNumber = 9;
            bool boolNumber = true;
            const int intValue = 8;

            Console.WriteLine(doubleNumber);
            Console.WriteLine(stringText);
            Console.WriteLine(charText);
            Console.WriteLine(intNumber);
            Console.WriteLine(boolNumber);
            Console.WriteLine(intValue);


            //Qustion 3
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Qustion 3");
            string[] car = { "Ford", "Land Cruiser", "Range Rover", "BMW", "Toyota" };
            Console.WriteLine( "Number of cars in the array is :" +car.Length);



            //Qustion 4
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Qustion 4");
           
            Console.Write("Please enter your firstname: ");
            string firstName = Console.ReadLine();

            Console.Write("Please enter your lastname: ");
            string lastName = Console.ReadLine();

            Console.Write("Input your year of birth: ");
            string yearOfBirth = Console.ReadLine();

            Console.WriteLine($"{firstName} {lastName} {yearOfBirth}");





            //Qustion 5
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Qustion 5");

            int[] array = new int[10];
            for (int i = 0; i <= 9; i++)
            {
                Console.Write($"Element-{i} : ");
                array[i] = int.Parse(Console.ReadLine());//use parse to conveart string to number 
            }
            Console.Write("Elements in array are: ");//to print the input 
            for (int i = 0; i < 10; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();



            //Qustion 6
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Qustion 6");


            int[] sumNumber = new int[5];
            for (int i = 0; i <= 4; i++)
            {
                Console.Write($"index-{i} : ");
                sumNumber[i] = int.Parse(Console.ReadLine());//use parse to conveart string to number 
            }
           
           
            int sum = 0;
                for (int i = 0; i < 5; i++)
                {
                    sum += sumNumber[i];
                }
            Console.WriteLine($"Sum of all elements stored in the array is: {sum}");


        }
    }
}
