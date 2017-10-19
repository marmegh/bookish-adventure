using System;

namespace starwars
{
    class Program
    {
        public static Humanoid[] player(string input){
            if(input == "jedi" || input == "Jedi"){
                System.Console.WriteLine("The force is strong with you. Do you have a name?");
                string name = Console.ReadLine();
                System.Console.WriteLine("It is time to pick the rest of your team. You can have a fighter and a smuggler or two fighters. Do you want two fighters? Y/N");
                string choice = Console.ReadLine();
                if (choice == "y" || choice == "Y"){
                    System.Console.WriteLine("Name your first fighter?");
                    string fighter1 = Console.ReadLine();
                    System.Console.WriteLine("Name your second fighter?");
                    string fighter2 = Console.ReadLine();
                    Humanoid[] players = {new Jedi(name), new Fighter(fighter1), new Fighter(fighter2)};
                    return players;
                }
                else{
                    System.Console.WriteLine("Name your only fighter?");
                    string fighter = Console.ReadLine();
                    System.Console.WriteLine("Name your smuggler?");
                    string smuggler = Console.ReadLine();
                    Humanoid[] players = {new Jedi(name), new Fighter(fighter), new Smuggler(smuggler)};
                    return players;
                }
            }
            else if(input == "fighter" || input == "Fighter"){
                System.Console.WriteLine("The resistance is grateful for your service. Please indicate your name to proceed to team assignment.");
                string name = Console.ReadLine();
                System.Console.WriteLine("It is time to pick the rest of your team. Would you like to fight with another smuggler? Y/N");
                string choice = Console.ReadLine();
                if (choice == "y" || choice == "Y"){
                    System.Console.WriteLine("Name your smuggler?");
                    string smuggler = Console.ReadLine();
                    System.Console.WriteLine("Name your jedi?");
                    string jedi = Console.ReadLine();
                    Humanoid[] players = {new Fighter(name), new Smuggler(smuggler), new Jedi(jedi)};
                    return players;
                }
                else{
                    System.Console.WriteLine("Name your other fighter?");
                    string fighter = Console.ReadLine();
                    System.Console.WriteLine("Name your jedi?");
                    string jedi = Console.ReadLine();
                    Humanoid[] players = {new Jedi(name), new Fighter(fighter), new Jedi(jedi)};
                    return players;
                }
            }
            else if(input == "smuggler" || input == "Smuggler"){
                System.Console.WriteLine("You've gotta be extra sneaky to run with this crew. This is the last time we will ask you for your name.");
                string name = Console.ReadLine();
                System.Console.WriteLine("Name your jedi");
                string jedi = Console.ReadLine();
                System.Console.WriteLine("Name your fighter");
                string fighter = Console.ReadLine();
                Humanoid[] players = {new Smuggler(name), new Jedi(jedi), new Fighter(fighter)};
                return players;
            }
            else{
                System.Console.WriteLine("Unfortunately, we don't need any {0} in the resistance. The Resistance will chose for you", input);
                string InputLine = Console.ReadLine();
                return player(InputLine);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the galaxy! You have been conscripted to fight in the Resistance. It is time to choose your team.");
            System.Console.WriteLine("Are you a jedi, fighter, or smuggler?");
            string InputLine = Console.ReadLine();
            Humanoid[] team = player(InputLine);

            }
        }
    }
}
