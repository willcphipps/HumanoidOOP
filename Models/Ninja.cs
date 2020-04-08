using System;

namespace Humanoid.Models
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            Name = name;
            Dexterity = 11;
            Health = 100;
        }
        public void Steal(Human target)
        {
            Health += 5;
            target.TakeDmg(5);
            Console.WriteLine($"{Name} has covertly stolen 5hp from {target.Name}");
        }
        public override int Attack(Human target)
        {
            if(target is Human)
            {
                int dmg = 3 * Dexterity;
                Random rand = new Random();
                int num = rand.Next(1, 5);
                if(num == 1)
                {
                    dmg += 10;
                    Console.WriteLine("Flying Ninja Style!");
                }
                target.TakeDmg(dmg);
                Console.WriteLine($"{Name} has attacked {target.Name} causing {dmg}hp of damage!");
                return dmg;
            }
            else
            {
                throw new Exception("You should work on your aim...");
            }
        }
        public override void ShowStats()
        {
            base.ShowStats();
        }
    }
}