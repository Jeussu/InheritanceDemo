using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    internal class Animal
    {
        // name properties
        public string Name { get; set; }
        //age property
        public int Age { get; set; }
        //is hungry boolean to check wether the animal is hungry

        public bool IsHungry { get; set; }

        //simple constructor

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            //in our case all our animals are hungry by default
            IsHungry = true;
        }

        // an empty virtual method MakeSound for other classes to override

        public virtual void MakeSoung()
        {

        }

        // a virtual method called Eat which sub classes can override

        public virtual void Eat()
        {
            //check if animal is hungry
            if (IsHungry)
            {
                //if yes then print the name of the animal + "is eating"
                Console.WriteLine($"{Name} is eating");
            }
            else
            {
                //otherwise print that the animal
                Console.WriteLine($"{Name} is not hungry");
            }
        }

        //virtual method Play

        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing");
        }
    }
}
