using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb_2
{
    class PitBull : Dog
    {
        protected bool _isHungry;

        public void StandGuard()
        {
            Console.WriteLine("{0} is standing guard", name);
            age++; Console.WriteLine("The Pitbull is now aged: {0}  \n", age);
        }
        public PitBull(string name, int age, string color, int weight, string AnimalSound, bool CanBark, bool isHungry):base(name,age,color,weight,AnimalSound,CanBark)
        {
            _isHungry = isHungry;
        }
        public PitBull() : this("¨No name is set¨", 0, "¨No color is set¨", 0, "¨No animalsound is set¨", false, false)
        {

        }
        public bool isHungry { get { return _isHungry; } set { _isHungry = value; } }
    }

}
