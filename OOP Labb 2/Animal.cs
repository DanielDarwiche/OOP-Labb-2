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
        public Animal() : this("¨No name is set¨",0,"¨No color is set¨",0,"¨No animalsound is set¨")
        { }
        public string name { get { return _name; } set { _name = value; } }
        public int age { get { return _age;} set { if (value <= 0) { value = 0; } _age = value; } }
        public string color { get { return _color; } set { _color = value; } }
        public int weight { get { return _weight; } set {if (value <= 0) { value = 1; }  _weight = value; } }
        public string AnimalSound { get { return _AnimalSound; } set { _AnimalSound = value; } }
        public void Eat()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Food has been eaten... Yummy...");
            weight += 8;
            Console.WriteLine("The animal {0} now weights: {1} \n",name, weight);
            if (weight == 100 ||weight > 100)
            {
                Console.WriteLine("The animal {0} is too heavy! Pooping should solve it \n",name);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void Poop()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (weight <11 && weight > 6)
            {
                Console.WriteLine("Poop has been pooped... Yucky...");
                Console.WriteLine("The animal is loosing weight! Stop pooping before it´s too late!");
                weight -= 4;
                Console.WriteLine("The animal  {0} now weights:{1}  \n", name , weight);
            }
            else if (weight <= 6)
            {
                Console.WriteLine("The animal {0} can not poop anymore! {1} weights too little! \n",name,name);
            }
            else
            {
                weight -= 4;
                Console.WriteLine("Poop has been pooped... Yucky...");
                Console.WriteLine("The animal {0} now weights:{1} \n " ,name, weight);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void Sleep()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Zzzzz... Sleep is occuring... Zzzzzz");
            age += 1;
            Console.WriteLine("After sleeping for so long, the animal {0} is now aged: {1} \n",name , age);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void MakeSound()
        {
            Console.WriteLine("The animal {0} loudly made the sound: {1} ! \n", name, AnimalSound);
        }
    }
}
