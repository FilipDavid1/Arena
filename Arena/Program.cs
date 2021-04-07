using System;

namespace Arena
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice sixWallDice = new Dice(6);
            Dice tenWallDice = new Dice(10);
            Fighter fighter = new Fighter("LordF", 100, 30, 15, tenWallDice);

            Console.WriteLine("Fighter {0}", fighter);
            Console.WriteLine("IsAlive {0}", fighter.IsAlive());
            Console.WriteLine("Health {0}", fighter.HelthGraph());

            Console.ReadKey();
        }

        
    }
}
