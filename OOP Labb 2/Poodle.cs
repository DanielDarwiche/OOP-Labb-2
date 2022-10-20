using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb_2
{
    class Poodle : Dog
    {
        public bool _isPlayful = true;
        public void RollAround()
        {
            Console.WriteLine("{0} is rolling around!", _name);
            _isPlayful = false;
            Console.WriteLine("The poodle is no longer playful, after playing for so long!");
            _weight -= 1;
            Console.WriteLine("After playing so much, the weight is now: {0} \n", _weight);
        }
        public Poodle(string name, int age, string color, int weight, string AnimalSound, bool CanBark, bool isPlayful)
        {
            _name = name;
            _age = age;
            _color = color;
            _weight = weight;
            _AnimalSound = AnimalSound;
            _CanBark = CanBark;
            _isPlayful = isPlayful;
        }
        public Poodle() : this("No name is set", 0, "No color is set", 0, "No animalsound is set", false, false)
        {

        }
    }

}
