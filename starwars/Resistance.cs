using System;
using System.Collections.Generic;

namespace starwars
{
    public class Resistance : Humanoid
    {
        public static Random rand = new Random();
        int count = 0;
        public Resistance(string name = "Oook") : base(name)
        {
            count++;
        }
    }

    public class Jedi : Resistance
    {
        public Jedi(string name = "Luke Skywalker")
        {
            this.name = name;
            this.health = 50;
            this.strength = 5;
            this.intelligence = 10;
            this.stealth = 0;
            this.agility = 0;
        }

        public void duel(Humanoid person)
        {
            System.Console.WriteLine("{0} strikes {1} with a lightsaber", this.name, person.name);
            fight(person);
        }

        public void forceattack(Humanoid person)
        {
            if(strength > person.strength)
            {
                fight(person);
            } else 
            {
                person.fight(this);
            }
        }
        public void meditate()
        {
            strength += 5;
        }
    }

    public class Fighter : Resistance
    {
        public Fighter(string name = "General Organa"): base(name)
        {
            this.health = 100;
            this.strength = 50;
            this.intelligence = 15;
            this.stealth = 5;
            this.agility = 30;
        }
        public void Blast(Humanoid person)
        {
            if(rand.Next(0,10) < 8)
            {
                System.Console.WriteLine("{0} fires a blaster at {1} and hits", this.name, person.name);
                fight(person);
            }
            else
            {
                System.Console.WriteLine("{0} fires a blaster at {1}, but misses", this.name, person.name);
            }
        }
    }
    public class Smuggler : Resistance
    {
        public Smuggler(string name = "Han Solo") : base(name)
        {
            this.health = 50;
            this.strength = 25;
            this.intelligence = 30;
            this.stealth = 50;
            this.agility = 20;
        }
        public void SneakAttack(Humanoid person)
        {
            if(rand.Next(1, 30) > 28)
            {
                System.Console.WriteLine("{0} caught attempting to cross enemy lines.", name);
                health = 0;
            } else {
                person.health -= 10;
            }
        }
    }
}