using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb_2
{
    class Animal
    { 
        public string _name;
        public int _age;
        public string _color;
        public int _weight;
        public string _AnimalSound;
        public Animal(string name, int age, string color, int weight, string AnimalSound)
        {
            _name = name;
            _age = age;
            _color = color;
            _weight = weight;
            _AnimalSound = AnimalSound;
        }
        public Animal() : this("No name is set",0,"No color is set",0,"No animalsound is set")
        {

        }
        public void Eat()
        {
            Console.WriteLine("Food has been eaten... Yummy...");
            _weight += 8;
            Console.WriteLine("The animal {0} now weights: {1} \n",_name, _weight);
            if (_weight == 100 || _weight > 100)
            {
                Console.WriteLine("The animal {0} is too heavy! Pooping should solve it \n",_name);
            }
        }
        public void Poop()
        {
            Console.WriteLine("Poop has been pooped... Yucky...");
            
            if (_weight == 9||_weight<9)
            {
                Console.WriteLine("The animal is loosing weight! Stop pooping before it´s too late!");
                _weight -= 4;
                Console.WriteLine("The animal  {0} now weights:{1}  \n", _name , _weight);
            }
            else if (_weight < 6)
            {
                Console.WriteLine("The animal {0} can not poop anymore! \n",_name);
            }
            else
            {
                _weight -= 4;
                Console.WriteLine("The animal {0} now weights:{1} \n " ,_name, _weight);
            }

        }
        public void Sleep()
        {
            Console.WriteLine("Zzzzz... Sleep is occuring... Zzzzzz");
            _age += 1;
            Console.WriteLine("After sleeping for so long, the animal {0} is now aged: {1} \n",_name , _age);
        }
        public void MakeSound()
        {
            Console.WriteLine("The animal {0} loudly made the sound: {1} ! \n", _name, _AnimalSound);
        }
    }
}
