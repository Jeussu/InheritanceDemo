using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualOverrideDemo;

namespace VirtualOverrideDemo
{
    internal class Dog : Animal
    {
        //bool property to check if the dog is Happy 

        public bool IsHappy { get; set; }

        //simple constructor where we pass the name and age to our base constructor
        public Dog(string name, int age) : base(name, age)
        {
            //all dogs are happy
            IsHappy = true;
        }

        //simple override of the virtual method Eat
        public override void Eat()
        {
            //to call the eat method from our base class we use the keyword
            base.Eat();
        }

        //override of the virtual method MakeSound
        public override void MakeSoung()
        {
            //since every animal will make a tottaly different sound
            // each animal will implement their own version of MakeSound
            Console.WriteLine("Wuuuf!");
        }

        //override of the virtual method Play
        public override void Play()
        {
            //check if the dog is happy if yes call play method from the base class
            if (IsHappy)
            {
                base.Play();
            }
        }
    }
}






