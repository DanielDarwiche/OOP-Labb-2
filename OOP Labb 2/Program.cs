using System;

namespace OOP_Labb_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("THIS IS TO TEST THE OBJECTS/Animals");            
            
            Horse Bettan = new Horse("", 17, "Black", 80, "Naaah", "Italian Stallion");
            Console.WriteLine("Bettans vikt är {0}, åldern är {1}, och rasen är {2}", Bettan._weight, Bettan._age, Bettan._TypeOfRace);
            Bettan.Eat();
            Bettan.Poop();
            Bettan.Sleep();
            Bettan.Trot();
            Console.WriteLine("Bettans vikt är {0}, åldern är {1}, och rasen är {2}", Bettan._weight, Bettan._age, Bettan._TypeOfRace);
            Console.WriteLine("****************************************************************");
            Poodle Bruno = new Poodle("Bruno", 8, "Vit", 10, "Grrrr", true, true);
            string lek = "";
            if (Bruno._isPlayful == true)
            {
                lek = "är leksam";
            }
            else if (Bruno._isPlayful == false)
            {
                lek = "är inte leksam";
            }
            Console.WriteLine("Brunos vikt är {0}, hans ålder är {1}, och han {2}.", Bruno._weight, Bruno._age, lek);
            Bruno.Eat();
            Bruno.Sleep();
            Bruno.playDead();
            Bruno.RollAround();
            Console.WriteLine("Brunos vikt är {0}, hans ålder är {1}, och han {2}.", Bruno._weight, Bruno._age, lek);
            Console.WriteLine("****************************************************************");
            Cat Ninja = new Cat("Ninja", 12, "Grey", 24, "MJAU MJAU MJAAAAU", true, 3);
            Console.WriteLine("Ninjas vikt är {0},  hennes ålder är {1}, och hon har mördat {2} antal möss.", Ninja._weight, Ninja._age, Ninja._miceKilled);
            Ninja.Eat();
            Ninja.Sleep();
            Ninja.killMouse();
            Ninja.Sleep();
            Ninja.Poop();
            Console.WriteLine("Ninjas vikt är {0}, hennes ålder är {1}, och hon har mördat {2} antal möss.", Ninja._weight, Ninja._age, Ninja._miceKilled);
            Console.WriteLine("****************************************************************");
            Console.WriteLine("Who wins in makeing animal sounds?");
            Ninja.MakeSound();
            Bruno.MakeSound();
            Bettan.MakeSound();
        }
    }
}
