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
        public int Intelligence;
        protected int Health;
        public Human(string name)
        {
            Name = name;
            Dexterity = 3;
            Strength = 3;
            Speed = 3;
            Intelligence = 3;
            Health = 100;
        }
        public Human(string name, int dex, int str, int intel, int spd)
        {
            Name = name;
            Dexterity = dex;
            Strength = str;
            Speed = spd;
            Intelligence = intel;
            Health = 100;
        }
        public void TakeDmg(int dmg)
        {
            Health -= dmg;
        }
        public void RestoreHealth(int hp)
        {
            Health += hp;
        }
        public void SamaraiDmg(int dmg)
        {
            if (Health <= dmg){
                Health = 0;
            }
        }
        public virtual void ShowStats()
        {
            Console.WriteLine($"Name: {Name}\nDexterity: {Dexterity}\nStrength: {Strength}\nSpeed: {Speed}\nHealth: {Health}");
        }
        
        public virtual int Attack(Human target)
        {
            if(target is Human)
            {
                int dmg = 3 * Strength;
                target.Health -= dmg;
                Console.WriteLine($"{Name} has attacked {target.Name} causing {dmg}hp of damage!");
                return target.Health;
            }
            else
            {
                throw new Exception("You should work on your aim...");
            }
        }
        // public int LightningStrike(Human target)
        //     {
        //     if(target is Human)
        //     {
        //         int dmg = 10 * Strength;
        //         target.Health -= dmg;
        //         Console.WriteLine($"{Name} shot a bolt of lightening through the heart of {target.Name}");
        //         return target.Health;
        //     }
        //     else
        //     {
        //         throw new Exception("Was that a sparkle in your hand or lightning?");
        //     }
        // }
    }

}