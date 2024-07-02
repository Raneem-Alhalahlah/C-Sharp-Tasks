using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task7
{
    internal class Program
    {
        public interface ISound
        {
          void MakeSound();
        }
         
        public abstract class Animal: ISound
        {
            public string Name { get; set; }

            public Animal(string name)
            {
                Name = Name;
            }

            public abstract void Eat();
            public void Sleep()//Concrete Classes:( abstract يعني فنكشن من دون )
            {
                Console.WriteLine($"{Name} is sleeping.");
            }

            public abstract void MakeSound();//(interface)هاد الفنكشن اجباري اضيفه لانه احنا هون بكلاس فرعي من 

        }

        public class Dog : Animal
        {
            public Dog(string name) : base(name) { }

            public override void Eat()
            {
                Console.WriteLine($"{Name} is eating dog food.");
            }

            public override void MakeSound()
            {
                Console.WriteLine($"{Name} says: Woof!");
            }
        }

        public class Cat : Animal
        {
            public Cat(string name) : base(name) { }

            public override void Eat()
            {
                Console.WriteLine($"{Name} is eating cat food.");
            }

            public override void MakeSound()
            {
                Console.WriteLine($"{Name} says: Meow!");
            }
        }


        static void Main(string[] args)
        {
            Dog dog = new Dog("Buddy");
            Cat cat = new Cat("Whiskers");

            dog.Eat();
            dog.Sleep();
            dog.MakeSound();

            cat.Eat();
            cat.Sleep();
            cat.MakeSound();
        }
    }
}
