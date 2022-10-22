using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb_2
{
    class Animal
    {
        protected string _name;
        protected int _age;
        protected string _color;
        protected int _weight;
        protected string _AnimalSound;

        public Animal(string name, int age, string color, int weight, string AnimalSound)
        {
            _name = name;
            _age = age;
            _color = color;
            _weight = weight;
            _AnimalSound = AnimalSound;
        }
        public Animal() : this("No name is set",0,"No color is set",0,"No animalsound is set")
        { }
        public string name { get { return _name; } set { _name = value; } }
        public int age { get { return _age;} set { _age = value; } }
        public string color { get { return _color; } set { _color = value; } }
        public int weight { get { return _weight; } set { _weight = value; } }
        public string AnimalSound { get { return _AnimalSound; } set { _AnimalSound = value; } }

        public void Eat()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Food has been eaten... Yummy...");
            _weight += 8;
            Console.WriteLine("The animal {0} now weights: {1} \n",_name, _weight);
            if (_weight == 100 || _weight > 100)
            {
                Console.WriteLine("The animal {0} is too heavy! Pooping should solve it \n",_name);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void Poop()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (_weight <11 && _weight > 6)
            {
                Console.WriteLine("Poop has been pooped... Yucky...");
                Console.WriteLine("The animal is loosing weight! Stop pooping before it´s too late!");
                _weight -= 4;
                Console.WriteLine("The animal  {0} now weights:{1}  \n", _name , _weight);
            }
            else if (_weight <= 6)
            {
                Console.WriteLine("The animal {0} can not poop anymore! {1} weights too little! \n",_name,_name);
            }
            else
            {
                _weight -= 4;
                Console.WriteLine("Poop has been pooped... Yucky...");
                Console.WriteLine("The animal {0} now weights:{1} \n " ,_name, _weight);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void Sleep()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Zzzzz... Sleep is occuring... Zzzzzz");
            _age += 1;
            Console.WriteLine("After sleeping for so long, the animal {0} is now aged: {1} \n",_name , _age);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void MakeSound()
        {
            Console.WriteLine("The animal {0} loudly made the sound: {1} ! \n", _name, _AnimalSound);
        }
    }
}
