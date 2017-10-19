using System;
using System.Collections.Generic;

namespace starwars{
    public class Empire : Humanoid{
        public static Random rand = new Random();
        int count = 0;
        public Empire(string name = "Oook") : base(name){
            count ++;
        }
    }
    public class Sith: Empire{
        public Sith(string name = "Mal"): base(name){
            this.name = "Darth " + name;
            this.health = 50;
            this.strength = 5;
            this.intelligence = 10;
            this.stealth = 0;
            this.agility = 0;
        }
        public void duel(Humanoid person){
            System.Console.WriteLine("{0} attacks {1} with a lightsaber", name, person.name);
            fight(person);
        }
        public void forceattack(Humanoid person){
            if(strength > person.strength){
                fight(person);
            }
            else{
                person.fight(this);
            }
        }
        public void meditate(){
            strength += 5;
        }
    }
    public class StormTrooper : Empire{
        public StormTrooper(string name = "trooper"): base (name){
            this.health = 100;
            this.strength = 50;
            this.intelligence = 2;
            this.stealth = 2;
            this.agility = 25;
        }
        public void Blast(Humanoid person){
            if (rand.Next(0,2) == 1){
                fight(person);
            }
            else{
                System.Console.WriteLine("{0} fires a blaster at {1}, but misses", name, person.name);
            }
        }
    }
    public class BountyHunter : Empire{
        public BountyHunter(string name = "Boba Fett") : base (name){
            this.health = 50;
            this.strength = 25;
            this.intelligence = 30;
            this.stealth = 50;
            this.agility = 20;
        }
        public void SneakAttack(Humanoid person){
            if (rand.Next(1-30) > 28){
                System.Console.WriteLine("{0} detected attempting to attack. Bounty Hunter successfully eliminated", name);
                health = 0;
            }
            else{
                person.health -= 10;
            }
        }
    }
}