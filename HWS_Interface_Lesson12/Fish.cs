using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWS_Interface_Lesson12
{
    internal class Fish : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("fish eat");
        }

        public void Move()
        {
            Console.WriteLine("fish move");

        }

        public void Sleep()
        {
            Console.WriteLine("fish sleep");
        }
    }
}
