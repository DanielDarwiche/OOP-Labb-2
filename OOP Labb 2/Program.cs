using System;

namespace OOP_Labb_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Horse Bettan = new Horse("Bettan", 17, "Black", 80, "Naaah", "Italian Stallion");
            Console.WriteLine(Bettan.name);
            Console.WriteLine("Bettans vikt är {0}, åldern är {1}, och rasen är {2}", Bettan.weight, Bettan.age, Bettan.TypeOfRace);
            Bettan.Eat();
            Bettan.Poop();
            Bettan.Sleep();
            Bettan.Trot();
            Bettan.MakeSound();
            Console.WriteLine("Bettans vikt är {0}, åldern är {1}, och rasen är {2}", Bettan.weight, Bettan.age, Bettan.TypeOfRace);
            Console.WriteLine("****************************************************************");
            Poodle Bruno = new Poodle("Bruno", 8, "Vit", 10, "Grrrr", true, true);
            string lek="";
            if (Bruno.isPlayful == true)
            {
                lek = "är leksam";
            }
            else if (Bruno.isPlayful == false)
            {
                lek = "är inte leksam";
            }
            Console.WriteLine("Brunos vikt är {0}, hans ålder är {1}, och han {2}.", Bruno.weight, Bruno.age, lek);
            Bruno.MakeSound();
            Bruno.Eat();
            Bruno.Sleep();
            Bruno.playDead();
            Bruno.RollAround();
            Bruno.Poop();
            Bruno.Poop();
            Bruno.Poop();
            Bruno.Poop();
            Bruno.Poop();
            Bruno.Poop();
            Console.WriteLine("Brunos vikt är {0}, hans ålder är {1}, och han {2}.", Bruno.weight, Bruno.age, lek);
            Console.WriteLine("****************************************************************");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("****************************************************************");
            Cat Ninja = new Cat("Ninja", 12, "Grey", 24, "MJAU MJAU MJAAAAU", true, 3);
            Console.WriteLine("Ninjas vikt är {0},  hennes ålder är {1}, och hon har mördat {2} antal möss.", Ninja.weight, Ninja.age, Ninja.miceKilled);
            Ninja.MakeSound();
            Ninja.Eat();
            Ninja.Sleep();
            Ninja.killMouse();
            Ninja.Sleep();
            Ninja.Poop();
            Console.WriteLine("Ninjas vikt är {0}, hennes ålder är {1}, och hon har mördat {2} antal möss.", Ninja.weight, Ninja.age, Ninja.miceKilled);
            Console.WriteLine("****************************************************************");
            Console.WriteLine("Who wins in makeing animal sounds?");
            Ninja.MakeSound();
            Bruno.MakeSound();
            Bettan.MakeSound();
            Console.WriteLine("Who won? You decide!");
        }
    }
}
