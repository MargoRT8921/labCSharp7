using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab7
{
    public abstract class Animal
    {
        public string Country { get; set; } 
        public string HideFromOtherAnimals { get; set; }
        public string Name { get; set; }
        public string WhatAnimal { get; set; }

        public Animal(string country, string hide, string name, string what)
        {
            Country = country;
            HideFromOtherAnimals = hide;
            Name = name;
            WhatAnimal = what;
        }
        public void Deconstruct()
        {
            Console.WriteLine("Deconstruct()");
        }
        public string GetClassificationAnimal()
        {
            return Name;
        }

    }
}