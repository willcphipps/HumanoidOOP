using System;
using System.Collections.Generic;
using Humanoid.Models;


namespace Humanoid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learning OOP for CSharp!");
            Human Thor = new Human("Thor, God of Thunder", 10, 1000, 500);
            
            Human Loki = new Human("Loki, God of Mischief");
            
            Thor.LightningStrike(Loki);
            Loki.ShowStats();
            Loki.Attack(Thor);
            Thor.ShowStats();
        }
    }
}
