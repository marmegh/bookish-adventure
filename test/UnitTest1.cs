using System;
using Xunit;
using starwars;


namespace test
{
    public class UnitTest1
    {
        Sith helmet = new Sith("Vader");
        Jedi obiwan = new Jedi("Ben Kenobi");
        [Fact]
        public void TestSithCreation()
        {
            Assert.Equal(helmet.name, "Darth Vader");
            Assert.Equal(helmet.health, 50);
            Assert.Equal(helmet.strength, 5);
            Assert.Equal(helmet.intelligence, 10);
            Assert.Equal(helmet.stealth, 0);
            Assert.Equal(helmet.agility, 0);
        }
        [Fact]
        public void TestJediCreation()
        {
            Assert.Equal(obiwan.name, "Ben Kenobi");
            Assert.Equal(obiwan.health, 50);
            Assert.Equal(obiwan.strength, 5);
            Assert.Equal(obiwan.intelligence, 10);
            Assert.Equal(obiwan.stealth, 0);
            Assert.Equal(obiwan.agility, 0);
        }

        [Fact]
        public void TestJediAttack()
        {
            int h1a = obiwan.health;
            int s1a = obiwan.strength;
            obiwan.meditate();
            int s1b = obiwan.strength;
            Assert.Equal(s1b - s1a, 5);
            int h2a = helmet.health;
            obiwan.fight(helmet);
            int h2b = helmet.health;
            Assert.Equal(20, h2a - h2b);
            obiwan.duel(helmet);
            int h2c = helmet.health;
            Assert.Equal(20, h2b - h2c);
        }
        [Fact]
        public void TestSithAttack()
        {
            int h1a = helmet.health;
            int s1a = helmet.strength;
            helmet.meditate();
            int s1b = helmet.strength;
            Assert.Equal(s1b - s1a, 5);
            int h2a = obiwan.health;
            helmet.fight(obiwan);
            int h2b = obiwan.health;
            Assert.Equal(20, h2a - h2b);
            helmet.duel(obiwan);
            int h2c = obiwan.health;
            Assert.Equal(20, h2b - h2c);
        }
    }
}
