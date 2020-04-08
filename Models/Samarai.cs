using System;

namespace Humanoid.Models
{
    public class Samarai : Human
    {

        public Samarai(string name) : base(name)
        {
            Name = name;
            Health = 200;
        }
        public override int Attack(Human target)
        {
            if(target is Human)
            {
                target.SamaraiDmg(50);
                return 50;
            }
            else
            {
                throw new Exception("You should work on your aim...");
            }
        }
        public void Meditate()
        {
            int hp = 200 - Health;
            Health += hp;
            Console.WriteLine("You have healed yourself through your own merit");
        }
        public override void ShowStats()
        {
            base.ShowStats();
        }

    }
}