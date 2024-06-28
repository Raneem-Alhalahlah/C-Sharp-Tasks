using System;

namespace C__Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Question 1
            //string[] ARR = [1, 7  9  45,] 
            //int[] ARR = { 1, 7, 9, 45 }; The True

            //int arr2 = ["Str" "alex","moh"
            //string[] arr2 = {"raneem","Jana"}; The true

            //string arr3 = 'the','fox' 'over' lazy, 'dog',  ]
            //string[] arr3 = { "the", "fox", "over", "lazy", "dog" }; The True


            //Question 2
            Console.WriteLine("Question2");
            String[] fruits = { "Tomato", "Banana", "Watermelon" };
            int indexOfBanana = 0;
            int indexOfTomato = 0;
            for (int i = 0; i < fruits.Length; i++)
            {
                if (fruits[i] == "Banana")
                {
                    indexOfBanana = i;
                }
                if (fruits[i] == "Tomato")
                {
                    indexOfTomato = i;
                }
            }
            Console.WriteLine("The index of 'Banana' is: " + indexOfBanana);
            Console.WriteLine("The index of 'Tomato' is: " + indexOfTomato);


            //Question 3
            Console.WriteLine( "");
            Console.WriteLine("Question 3");
            string[] favoriteFoods = { "Pizza", "shawerma", "Burgers", "Pasta", "Ice Cream" };
            string[] favoriteSports = { "Soccer", "Basketball", "Tennis" };
            string[] favoriteMovies = { "Inception", "The Matrix", "Interstellar", "The Dark Knight" };


            Console.WriteLine("Favorite Foods:");
            foreach (string food in favoriteFoods)
            {
                Console.WriteLine(food);
            }
            Console.WriteLine("-----------");
            Console.WriteLine("Favorite Sports :");
            foreach (string sport in favoriteSports)
            {
                Console.WriteLine(sport);
            }

            Console.WriteLine("------------");
            Console.WriteLine("Favorite Movies :");
            foreach (string moves in favoriteMovies)
            {
                Console.WriteLine(moves);
            }

            // Using (For loop)
            Console.WriteLine("///////////////////////////////////////////////////////");
            Console.WriteLine("Favorite Foods:");
            for (int i = 0; i < favoriteFoods.Length; i++)
            {
                Console.WriteLine(favoriteFoods[i]);
            }

            Console.WriteLine("-----------");

            Console.WriteLine("Favorite Sport:");
            for(int i=0;i<favoriteSports.Length; i++)
            {
                Console.WriteLine(favoriteSports[i]);
            }

            Console.WriteLine("-----------");

            Console.WriteLine("Favorite Movies:");
            for (int i = 0; i < favoriteMovies.Length; i++)
            {
                Console.WriteLine(favoriteMovies[i]);
            }


            //Question 4
            Console.WriteLine("");
            Console.WriteLine("Questio 4");
            Console.WriteLine("Input three numbers separated by comma: ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(',');
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int num = int.Parse(numbers[i]);
                sum += num;
            }
            Console.WriteLine("The sum of three numbers: " + sum);

            //Question 5
            Console.WriteLine("");
            Console.WriteLine("Question 5");
            int summ = 0;
            Console.WriteLine("Odd numbers and their sum from 1 to 100:");
            for (int i = 1; i <= 100; i += 2)
            {
                Console.Write(i + " "); 
                summ += i; 
            }
            Console.WriteLine($"\n\nThe sum of odd numbers is: {summ}");


            //Question 6
            Console.WriteLine("");
            Console.WriteLine("Question 6");
            int rows = 4; 
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" "); 
                }

                
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");             
                }

                Console.WriteLine();
            }

            //Question 7
            Console.WriteLine("");
            Console.WriteLine("Question 7");
            int rowss = 4; 
            int numberss = 1; 

            for (int i = 1; i <= rowss; i++)
            {
                // Inner loop
                for (int j = 1; j <= rowss - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write(numberss + " ");
                    numberss++;
                }
                Console.WriteLine();

            }



















            }
    }
}
