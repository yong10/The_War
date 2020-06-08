using System;

namespace The_War.Models
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            Name = name;
            health = 50;
            Intelligence = 25;
        }

        
        public override int Attack(Human target)
        {
            int dmg = Intelligence * 5;
            target.health -= dmg;
            this.health += dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage and stole {dmg}hp from {target.Name}!");
            Console.WriteLine($"{this.Name}'s Hp: {this.health}, {target.Name}'s Hp: {target.health}");
            return target.health;
        }

        public int Heal(Human target)
        {
            int heal = Intelligence * 10;
            target.health += heal;
            Console.WriteLine($"{Name} healed {target.Name} for {heal}hp!");
            Console.WriteLine($"{this.Name}'s Hp: {this.health}, {target.Name}'s Hp: {target.health}");
            return target.health;
        }
    }
}