using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb_2
{
    class Dog : Animal
    {
        protected bool _CanBark;
        public void playDead()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Oh no! Is {0} dead? No... He´s just playing dead.", name);
            age += 1; Console.WriteLine("The dog played dead so long that the age now is: {0} \n ", age);
            Console.ForegroundColor = ConsoleColor.White;

        }
        public Dog(string name, int age, string color, int weight, string AnimalSound, bool CanBark) :base(name,age,color,weight,AnimalSound)
        {// public Tabletop(double l, double w) : base(l, w)
           
        }
        public Dog() : this("¨No name is set¨", 0, "¨No color is set¨", 0, "¨No animalsound is set¨", false)
        {

        }
        public bool CanBark { get { return _CanBark; } set { _CanBark = value; } }

    }

}
