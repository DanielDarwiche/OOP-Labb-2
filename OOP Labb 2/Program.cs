using System;

namespace OOP_Labb_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal AnimOne = new Animal("Bert",3, "Black",18, "Woof");
            //Animal Bebe = new Animal();
            //Console.WriteLine(Bebe._name);

            //Horse hasten = new Horse();
            //Console.WriteLine(hasten._color);

            //Dog doggi = new Dog("Ann",5,"blue",7,"wiff Wiff",true);

            //doggi.Poop();
            //doggi.Eat();
            //doggi.Eat();

            //doggi.Eat();
            //doggi.Eat();
            //doggi.Eat();

            //Poodle Fedor = new Poodle("Fedor",20, "Brun",10,"grrrr",true, true);
            //Fedor.Eat();
            //Fedor.RollAround();
            //Console.WriteLine(Fedor._age);
            //Fedor.Sleep();

            //AnimOne.MakeSound();
            //Bebe.MakeSound();
            //hasten.MakeSound();
            //doggi.MakeSound();
            //Fedor.MakeSound();
            Cat Ninja = new Cat("Ninja",12,"Grey",24,"MJAU MJAU MJAAAAU",true,3);
            Console.WriteLine("Ninjas vikt är {0},  hennes ålder är {1}, och hon har mördat {2} antal möss.", Ninja._weight, Ninja._age, Ninja._miceKilled);
            Ninja.MakeSound();
            Ninja.Eat();
            Ninja.Sleep();
            Ninja.killMouse();
            Ninja.Sleep();
            Ninja.Poop();
            Console.WriteLine("Ninjas vikt är {0}, hennes ålder är {1}, och hon har mördat {2} antal möss.",Ninja._weight ,Ninja._age, Ninja._miceKilled);
        }
    }
}
