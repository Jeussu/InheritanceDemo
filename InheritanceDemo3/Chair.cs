﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo3
{
    internal class Chair : Furniture, IDestroyable
    {
        //implementing the interface's property
        public string DestructionSound { get; set; }



        // simple constructor
        public Chair(string color, string material)
        {
            this.Color = color;
            this.Material = material;
            //initializing the interface's property with a value in the constructor
            DestructionSound = "ChairDestructionSound.mp3";
        }

        //implementing the interface's method
        public void Destroy()
        {
            //when a chair gets destroyed we should play the destruction sound
            // and spawn the destroyed chair parts
            Console.WriteLine($"The {Color} chair was destroyed");
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Spawning chair parts");
        }
    }
}
