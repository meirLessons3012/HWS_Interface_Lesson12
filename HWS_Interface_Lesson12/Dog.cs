using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWS_Interface_Lesson12
{
    internal class Dog : IAnimal, IMakeSoundable
    {
        public string Name { get; set; }
        public void Eat()
        {
            Console.WriteLine("Dog eat");
        }

        public void MakeSoundWhileating()
        {
            Name = "dogi";
            Console.WriteLine("yami yammi from dog...");
        }

        public void Move()
        {
            Console.WriteLine("Dog move");

        }

        public void Sleep()
        {
            Console.WriteLine("Dog sleep");
        }
    }
}
