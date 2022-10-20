using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb_2
{
    class Cat : Animal
    {
        public bool _isStriped;
        public int _miceKilled;
        public void killMouse()
        {
            _miceKilled++; Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("A mouse has been killed");
            Console.WriteLine("{0} has killes {1} mice! Bad Kitty! \n", _name, _miceKilled);
            if (_weight % 2 == 0)
            {
                _weight += 5;
                Console.WriteLine("The cat ate the mouse, this time, and now weights: {0} \n", _weight);
            }
            else
            {
                _weight += 2;
                Console.WriteLine("The cat ate PART OF the mouse, this time, and now weights: {0} \n", _weight);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        public Cat(string name, int age, string color, int weight, string AnimalSound, bool isStriped, int miceKilled)
        {
            _name = name;
            _age = age;
            _color = color;
            _weight = weight;
            _AnimalSound = AnimalSound;
            _isStriped = isStriped;
            _miceKilled = miceKilled;

        }
        public Cat() : this("No name is set", 0, "No color is set", 0, "No animalsound is set", false, 0)
        {

        }
    }

}
