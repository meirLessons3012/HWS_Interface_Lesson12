using System;

namespace HWS_Interface_Lesson12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fish fish = new Fish();
            IAnimal fish2 = new Fish();
            Dog dog = new Dog();
            IAnimal dog2 = new Dog();

            IAnimal[] animals = new IAnimal[] { fish, dog, dog2 };

            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].Move();
            }

            AnimalIsHungry(fish);
            AnimalIsHungry(dog);
        }

        public static void AnimalIsHungry(IAnimal animal)
        {
            //short way                
            (animal as IMakeSoundable)?.MakeSoundWhileating();
            if (animal is IMakeSoundable x)
            {
                //animal.MakeSound();//Error

                //long way
                IMakeSoundable animalMakeSound = animal as IMakeSoundable;
                animalMakeSound.MakeSoundWhileating();
            }
            animal.Eat();
        }
    }
}
