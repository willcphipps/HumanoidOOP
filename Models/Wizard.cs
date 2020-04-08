using System;

namespace Humanoid.Models
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            Name = name;
            Health = 50;
            Intelligence = 12;
        }
        public override void ShowStats()
        {
            base.ShowStats();
            Console.WriteLine($"Intelligence:{Intelligence}");
        }
        public int Heal(Human target)
        {
            if (target is Human)
            {
                int hp = 4 * Intelligence;
                target.RestoreHealth(hp);
                return hp;
            }
            else 
            {
                throw new Exception("Your Magic is only useful to humans");
            }
        }
        public override int Attack(Human target)
        {
            if(target is Human)
            {
                int dmg = 5 * Intelligence;
                target.TakeDmg(dmg);
                Console.WriteLine($"{Name} has attacked {target.Name} causing {dmg}hp of damage!");
                Health += dmg;
                return dmg;
            }
            else
            {
                throw new Exception("You should work on your aim...");
            }
        }

    }
}