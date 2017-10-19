using System;
using System.Collections.Generic;

namespace starwars
{
    public class Program
    {
        public static Random rand = new Random();
        public static List<Humanoid> player(string input){
            List<Humanoid> players = new List<Humanoid>();
            if(input == "jedi" || input == "Jedi"){
                System.Console.WriteLine("The force is strong with you. Do you have a name?");
                string name = Console.ReadLine();
                players.Add(new Jedi(name));
                System.Console.WriteLine("It is time to pick the rest of your team. You can have a fighter and a smuggler or two fighters. Do you want two fighters? Y/N");
                string choice = Console.ReadLine();
                if (choice == "y" || choice == "Y"){
                    System.Console.WriteLine("Name your first fighter?");
                    players.Add(new Fighter(Console.ReadLine()));
                    System.Console.WriteLine("Name your second fighter?");
                    players.Add(new Fighter(Console.ReadLine()));
                    return players;
                }
                else{
                    System.Console.WriteLine("Name your only fighter?");
                    players.Add(new Fighter(Console.ReadLine()));
                    System.Console.WriteLine("Name your smuggler?");
                    players.Add(new Smuggler(Console.ReadLine()));
                    return players;
                }
            }
            else if(input == "fighter" || input == "Fighter"){
                System.Console.WriteLine("The resistance is grateful for your service. Please indicate your name to proceed to team assignment.");
                players.Add(new Fighter(Console.ReadLine()));
                System.Console.WriteLine("It is time to pick the rest of your team. Would you like to fight with another smuggler? Y/N");
                string choice = Console.ReadLine();
                if (choice == "y" || choice == "Y"){
                    System.Console.WriteLine("Name your smuggler?");
                    players.Add(new Smuggler(Console.ReadLine()));
                    System.Console.WriteLine("Name your jedi?");
                    players.Add(new Jedi(Console.ReadLine()));
                    return players;
                }
                else{
                    System.Console.WriteLine("Name your other fighter?");
                    players.Add(new Fighter(Console.ReadLine()));
                    System.Console.WriteLine("Name your jedi?");
                    players.Add(new Jedi(Console.ReadLine()));
                    return players;
                }
            }
            else if(input == "smuggler" || input == "Smuggler"){
                System.Console.WriteLine("You've gotta be extra sneaky to run with this crew. This is the last time we will ask you for your name.");
                players.Add(new Smuggler(Console.ReadLine()));
                System.Console.WriteLine("Name your jedi");
                players.Add(new Jedi(Console.ReadLine()));
                System.Console.WriteLine("Name your fighter");
                players.Add(new Fighter(Console.ReadLine()));
                return players;
            }
            else{
                System.Console.WriteLine("Unfortunately, we don't need any {0} in the resistance. The Resistance will chose for you", input);
                string InputLine = Console.ReadLine();
                return player(InputLine);
            }
        }
        public static List<Humanoid> enemyGen(int playCounter){
            List<Humanoid> enemies = new List<Humanoid>();
            if (playCounter < 2){
                enemies.Add(new StormTrooper());                
            }
            else if (playCounter < 5){
                enemies.Add(new StormTrooper());
                enemies.Add(new StormTrooper());
            }
            else if (playCounter <10){
                enemies.Add(new StormTrooper());
                enemies.Add(new StormTrooper());
            }
            else if (playCounter == 10){
                enemies.Add(new BountyHunter());
                enemies.Add(new StormTrooper());
            }
            else if(playCounter <20){
                enemies.Add(new BountyHunter());
                enemies.Add(new StormTrooper());
                enemies.Add(new StormTrooper());
            }
            else if(playCounter == 20){
                enemies.Add(new Sith());
                enemies.Add(new StormTrooper());
                enemies.Add(new StormTrooper());
            }
            return enemies;
        }
        public static bool turn(List<Humanoid> team, List<Humanoid> enemies, bool TurnInfo = true){
            System.Console.WriteLine("Fight in progress");
            if(TurnInfo){
                Humanoid active = team[0];
                team.RemoveAt(0);
                team.Add(active);
                int select = rand.Next(0, enemies.Count -1);
                Humanoid selected = enemies[select];
                return( engagement(team, enemies, active, selected, TurnInfo));
            }
            else{
                Humanoid active = enemies[0];
                enemies.RemoveAt(0);
                enemies.Add(active);
                int select = rand.Next(0, team.Count -1);
                Humanoid selected = team[select];
                return( engagement(enemies, team, active, selected, TurnInfo));
            }
        }
        public static bool engagement(List<Humanoid> attackerTeam, List<Humanoid> attackedTeam, Humanoid attacker, Humanoid attacked, bool TurnInfo){
            attacker.fight(attacked);
            if (attacked.health <= 0){
                attackedTeam.Remove(attacked);
            }
            return(!TurnInfo);
        }
        static void Main(string[] args)
        {
            int playCounter = 0;
            Console.WriteLine("Welcome to the galaxy! You have been conscripted to fight in the Resistance. It is time to choose your team.");
            System.Console.WriteLine("Are you a jedi, fighter, or smuggler?");
            string InputLine = Console.ReadLine();
            List<Humanoid> team = player(InputLine);
            Console.WriteLine("It is time for your first mission. You can infiltrate the enemy base or provide cover for the infiltration team. Which would you prefer? Infiltrate/Cover");
            string response = Console.ReadLine();
            if (response == "Cover" || response =="cover"){
                System.Console.WriteLine("Mission failed. You provided lousy cover. Ground team lost.");
            }
            else{
                System.Console.WriteLine("Entering enemy base...");
                List<Humanoid> enemies = enemyGen(playCounter++);
                while(enemies.Count > 0 && team.Count> 0){
                    turn(team, enemies, true);
                }
            }
        }
    }
}
