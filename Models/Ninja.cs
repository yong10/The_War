using System;

namespace The_War.Models
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            Name = name;
            health = 100;
            Dexterity = 175;
        }

        public override int Attack(Human target)
        {
            Random rand = new Random();
            int x = rand.Next(0,100);
            int extraDmg = 0;
            if(x <= 20)
            {
                extraDmg = 20;
            }

            int dmg = (Dexterity * 5) - extraDmg;
            target.health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage and store {dmg}hp!");
            Console.WriteLine($"{this.Name}'s Hp: {this.health}, {target.Name}'s Hp: {target.health}");
            return target.health;
        }
        public int Steal(Human target)
        {
            target.health -= 5;
            this.health += 5;
            Console.WriteLine($"{Name} stole 5hp from {target.Name}!");
            Console.WriteLine($"{this.Name}'s Hp: {this.health}, {target.Name}'s Hp: {target.health}");
            return target.health;
        }
    }
}