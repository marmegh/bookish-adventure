namespace starwars{
    public class Humanoid{
        public int health;
        public int strength;
        public int intelligence;
        public int stealth;
        public int agility;
        public string name;
        public Humanoid(string name = "Oook"){
            this.name = name;
        }
        public void fight(Humanoid person){
            person.health -= strength*2;
        }
    }
}