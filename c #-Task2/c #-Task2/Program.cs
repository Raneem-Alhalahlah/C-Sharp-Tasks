using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c___Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.Write("Enter the first integer number  :");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the Second integer number  :");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 < number2)
            {
                Console.WriteLine("The smaller number is :" + number1);
            }
            else { Console.WriteLine("The smaller number is :" + number2); }



            //Question 2
            Console.WriteLine("  ");
            Console.WriteLine("Question 2");

            Console.WriteLine("Enter any number");
            int num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("The Sign of number is (-)");
            }
            else if (num > 0)
            {
                Console.WriteLine("The Sign of number is (+)");
            }



            //Question 3
            { Console.WriteLine("  "); }
            Console.WriteLine("Question 3");
            Console.Write("Enter the first Number : ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second Number : ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the third Number : ");
            int num3 = int.Parse(Console.ReadLine());

            int[] numbers = { num1, num2, num3 };
            Array.Sort(numbers);
            Console.WriteLine("The numbers in ascending order are: " + string.Join(", ", numbers)); //  is a method that concatenates the elements of a collection (like an array)


            //Question 4
            { Console.WriteLine("  "); }
            Console.WriteLine("Question 4");
            Console.Write("Enter the first Number : ");
            int Number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second Number : ");
            int Number2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the third Number : ");
            int Number3 = int.Parse(Console.ReadLine());
            Console.Write("Enter the fourth Number : ");
            int Number4 = int.Parse(Console.ReadLine());

            Console.Write("Enter the fifth Number : ");
            int Number5 = int.Parse(Console.ReadLine());


            int[] Numbers = { Number1, Number2, Number3, Number4, Number5 };
            int maxNumber = Numbers.Max();
            Console.WriteLine("The maximum number is: " + maxNumber);


            //Question 5
            { Console.WriteLine("  "); }
            Console.WriteLine("Question 5");
            Console.Write("Input kilometers per hour: ");
            double kmPerHour = double.Parse(Console.ReadLine());

            double milesPerHour = kmPerHour * 0.621371;
            Console.WriteLine($"{kmPerHour} kilometers per hour is equal to {milesPerHour} miles per hour.");


            //Question 6
            { Console.WriteLine("  "); }
            Console.WriteLine("Question 6");
            Console.Write("Input hours: ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Input minutes: ");
            int minutes = int.Parse(Console.ReadLine());

            int totalMinutes = (hours * 60) + minutes;

            Console.WriteLine("Total: " + totalMinutes + " minutes.");



            //Question 7
            { Console.WriteLine("  "); }
            Console.WriteLine("Question 7");
            Console.Write("Input minutes: ");
            int totalMinutes1 = int.Parse(Console.ReadLine());

            int hours1 = totalMinutes1 / 60;
            int remainingMinutes = totalMinutes1 % 60;

            Console.WriteLine($"{hours1} Hours, {remainingMinutes} Minutes");


            //Question 8
            { Console.WriteLine("  "); }
            Console.WriteLine("Question 8");

            string[] sentences = {
            "my name is raneem",
            "im happy ",
            "I want to be a good person ",
            "Coding academy",
            "The food is the best"
        };
            foreach (string sentence in sentences)
            {
                Console.WriteLine($"{sentence} - Length: {sentence.Length} characters");
            }


        }

    }
}

