using System;
using System.Collections.Generic;


namespace Humanoid.Models
{
    public class Human
    {
        public string Name;
        public int Dexterity;
        public int Strength;
        public int Speed;
        private int health;
        public int Health
        {
            get { return health; }
        }
        public Human(string name)
        {
            Name = name;
            Dexterity = 5;
            Strength = 5;
            Speed = 5;
            health = 100;
        }

        public Human(string name, int dex, int str, int spd)
        {
            Name = name;
            Dexterity = dex;
            Strength = str;
            Speed = spd;
            health = 100;
        }
        public void ShowStats()
        {
            Console.WriteLine($"Name: {Name}\nDexterity: {Dexterity}\nStrength: {Strength}\nSpeed: {Speed}\nHealth: {Health}");
        }
        public int Attack(Human target)
        {
            if(target is Human)
            {
                int dmg = 5 * Strength;
                target.health -= dmg;
                Console.WriteLine($"{Name} has attacked {target.Name} causing {dmg}hp of damage!");
                return target.health;
            }
            else
            {
                throw new Exception("You should work on your aim...");
            }
        }
        public int LightningStrike(Human target)
            {
            if(target is Human)
            {
                int dmg = 10 * Strength;
                target.health -= dmg;
                Console.WriteLine($"{Name} shot a bolt of lightening through the heart of {target.Name}");
                return target.health;
            }
            else
            {
                throw new Exception("Was that a sparkle in your hand or lightning?");
            }
        }
    }

}