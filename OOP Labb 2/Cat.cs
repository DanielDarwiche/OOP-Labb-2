using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb_2
{
    class Cat : Animal
    {
        protected bool _isStriped;
        protected int _miceKilled;

        public void killMouse()
        {
            miceKilled++; Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("A mouse has been killed");
            Console.WriteLine("{0} has killes {1} mice! Bad Kitty! \n", name, miceKilled);
            if (miceKilled % 2 == 0)
            {
                weight += 5;
                Console.WriteLine("The cat ate the mouse, this time, and now weights: {0} \n", weight);
            }
            else
            {
                weight += 2;
                Console.WriteLine("The cat ate PART OF the mouse, this time, and now weights: {0} \n", weight);
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
        public Cat() : this("¨No name is set¨", 0, "¨No color is set¨", 0, "¨No animalsound is set¨", false, 0)
        {

        }

        public bool isStriped { get { return _isStriped; } set { _isStriped = value; } }
        public int miceKilled { get { return _miceKilled; } set { _miceKilled = value; } }
    }

}
