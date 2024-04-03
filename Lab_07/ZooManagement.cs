using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public abstract class Animal
    {
        public abstract void MakeSound();
      
    }

    public class Lion : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Lion Roars");
        }
    }

    public class Tiger : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Tiger Growls");
        }
    }

    public class Elephant : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Elephant Trumpets");
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            Console.WriteLine("Enter the type of the animal :");
            string animalType = Console.ReadLine();
            
            Animal animalSound = null;
            switch(animalType.ToLower())
            {
                case "tiger": animalSound = new Tiger(); break;
                case "lion": animalSound = new Lion(); break;
                case "elephant": animalSound = new Elephant(); break;
            }
            
            animals.Add(animalSound);
            Console.WriteLine("Animal is added");
            Console.WriteLine("The sound of the added animal :");

            foreach(Animal animal in animals)
            {
                animal.MakeSound();
            }
            Console.ReadLine();
        }
    }
}
