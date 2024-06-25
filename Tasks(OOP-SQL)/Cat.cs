using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_OOP_SQL_
{
    internal class Cat : Animal
    {
        public Cat(int age) : base(age)
        {
        }

        public override int CountOflegs()
        {
            return 4;
        }

        public override void MakeVoice()
        {
            Console.WriteLine("Miav");
        }
    }
}
