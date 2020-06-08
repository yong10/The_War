using System;

namespace The_War.Models
{
    public class Samurai : Human
    {
        public Samurai(string name): base(name)
        {
            Name = name;
        }

        public override int Attack(Human target)
        {   
            int dmg = 0;
            if (target.health >0 && target.health < 50)
            {
                dmg =  target.health;
            }

            target.health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            Console.WriteLine($"{this.Name}'s Hp: {this.health}, {target.Name}'s Hp: {target.health}");
            return target.health;
        }
        public int Meditate()
        {
            if(this.health < 0)
                {
                    this.health = 100;
                    Console.WriteLine($"{Name} meditated himself and recovered back to full hp!");
                    Console.WriteLine($"{this.Name}'s Hp: {this.health}");
                }
                return this.health;
        }
    }
}