using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_OOP_SQL_
{
    internal abstract class Animal
    {
        public int Age {  get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }

        public Animal(int age) 
        {
            Age = age;
            Console.WriteLine($"May animal age is{age}");
        }

        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
        public abstract void MakeVoice();

        public abstract int CountOflegs();
    }
}
