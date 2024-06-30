using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Task4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("Question 1");
            //Console.WriteLine("Input the 10 Number :");
            //(int sum, double average) = CalculateSumAndAverage();

            //Console.WriteLine("The sum of 10 numbers is: " + sum);
            //Console.WriteLine("The average is: " + average);





            Console.WriteLine("");
            Console.WriteLine("Question 2");
            Console.Write("Input number of terms: ");
            int num = int.Parse(Console.ReadLine());
            CubeCalculator calculator = new CubeCalculator();

            for (int i = 1; i <= num; i++)//this for make sereis from 1 to the input number.
            {
                int cube = calculator.CalculateCube(i);
                Console.WriteLine($"Number is : {i} and cube of the {i} is : {cube}");
            }




            Console.WriteLine("");
            Console.WriteLine("Question 3");
            int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };


            YearFilter filter = new YearFilter();
            int[] filteredYears = filter.GetYearsGreaterThan(years, 1950);
            Console.WriteLine("Years greater than 1950:");
            foreach (int year in filteredYears)
            {
                Console.WriteLine(year);
            }

            Console.WriteLine("");
            Console.WriteLine("Question 4");
            AgeConverter converter = new AgeConverter();

            int ageInYears = 24;
            int ageInDays = converter.CalculateAgeInDays(ageInYears);

            Console.WriteLine($"Age in years: {ageInYears}");
            Console.WriteLine($"Age in days: {ageInDays}");





            //method for Q1
            //public static (int, double) CalculateSumAndAverage()
            //    {
            //        int[] numbers = new int[10];
            //        int sum = 0;

            //        for (int i = 0; i < 10; i++)
            //        {
            //            Console.Write("Number-" + (i + 1) + " : ");
            //            numbers[i] = int.Parse(Console.ReadLine());
            //            sum += numbers[i];
            //        }

            //        double average = (double)sum / 10;

            //        return (sum, average);

            //    }

            Console.WriteLine("");
            Console.WriteLine("Question 5");
            Person person = new Person();

            
            person.Age = 30;
            person.Gender = "Male";
            person.Name = "John Doe";
            person.Email = "john.doe@example.com";
            person.ID = "1234567890";
            person.Phone = "0771234567";

          
            Console.WriteLine($"Name: {person.Name}");
            Console.WriteLine($"Age: {person.Age}");
            Console.WriteLine($"Gender: {person.Gender}");
            Console.WriteLine($"Email: {person.Email}");
            Console.WriteLine($"ID: {person.ID}");
            Console.WriteLine($"Phone: {person.Phone}");

        }

    }



        //Class and method for Q2
        public class CubeCalculator
        {
            public int CalculateCube(int number)
            {
                return number * number * number;
            }
        }


    //Class and method for Q3
    public class YearFilter
    {
        public int[] GetYearsGreaterThan(int[] years, int threshold)
        {
            List<int> filteredYears = new List<int>();

            foreach (int year in years)
            {
                if (year > threshold)
                {
                    filteredYears.Add(year);
                }
            }

            return filteredYears.ToArray();

        }


    }
     //Class and method for Q4
    public class AgeConverter
    {
        
        public int CalculateAgeInDays(int ageInYears)
        {
            
            int ageInDays = ageInYears * 365;
            return ageInDays;
        }
    }




    public class Person
    {
        // Fields
        private int age;
        private string gender;
        private string name;
        private string email;
        private string id;
        private string phone;

        public Person()
        {
            age = 18; // Default age
            gender = "Unknown"; // Default gender
            name = "Unknown"; // Default name
            email = "example@example.com"; // Default email
            id = "0000000000"; // Default ID
            phone = "0771234567"; // Default phone number
        }

        
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 18 && value <= 60)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException("Age must be between 18 and 60.");
                }
            }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Phone
        {
            get { return phone; }
            set
            {
                if (value.StartsWith("077") || value.StartsWith("078") || value.StartsWith("079"))
                {
                    phone = value;
                }
                else
                {
                    throw new ArgumentException("Phone number must start with 077, 078, or 079.");
                }
            }
        }
    }







}






   





