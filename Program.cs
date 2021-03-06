﻿using System;
using System.Collections.Generic;
using Humanoid.Models;


namespace Humanoid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learning OOP for CSharp!");
            Human Thor = new Human("Thor, God of Thunder", 10, 100, 10, 10);
            Human Loki = new Human("Loki, God of Mischief");
            // Thor.LightningStrike(Loki);
            // Loki.ShowStats();
            // Loki.Attack(Thor);
            // Thor.ShowStats();
            Wizard doc = new Wizard("Doctor Steven Strange");
            doc.ShowStats();
            Ninja naruto = new Ninja("Naruto Shipoden");
            // naruto.ShowStats();
            // naruto.Attack(Loki);
            // Loki.ShowStats();
            // doc.Attack(Thor);
            // Thor.ShowStats();
            // doc.ShowStats();
            // doc.Heal(Thor);
            // Thor.ShowStats();
            naruto.Steal(doc);
            naruto.Attack(doc);
        }
    }
}
