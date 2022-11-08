using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb_2
{
    class Horse : Animal
    {
        public string _TypeOfRace;
        public Horse(string name, int age, string color, int weight, string AnimalSound, string TypeOfRace)
        {
            _name = name;
            _age = age;
            _color = color;
            _weight = weight;
            _AnimalSound = AnimalSound;
            _TypeOfRace = TypeOfRace;
        }
        public Horse() : this("¨No name is set¨", 0, "¨No color is set¨", 0, "¨No animalsound is set¨", "'No race is set'")
        {
        }
        public void Trot()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The horse {0} is trotting around. Yippie! \n", _name);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
