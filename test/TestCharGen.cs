using System;
using Xunit;
using starwars;

namespace test
{
    public class CharGenTest
    {
        [Fact]
        public void TestSithCreation()
        {
            Sith helmet = new Sith("Vader");
            Assert.Equal(helmet.name, "Darth Vader");
            Assert.Equal(helmet.health, 50);
            Assert.Equal(helmet.strength, 5);
            Assert.Equal(helmet.intelligence, 10);
            Assert.Equal(helmet.stealth, 0);
            Assert.Equal(helmet.agility, 0);
        }
        public void TestStormTrooperCreation()
        {
            StormTrooper finn = new StormTrooper();
            Assert.Equal(finn.name, "trooper");
            Assert.Equal(finn.health, 10);
            Assert.Equal(finn.strength, 50);
            Assert.Equal(finn.intelligence, 2);
            Assert.Equal(finn.stealth, 2);
            Assert.Equal(finn.agility, 25);
        }
        public void TestBountyHunterCreation()
        {
            BountyHunter boba = new BountyHunter();
            Assert.Equal(boba.name, "Boba Fett");
            Assert.Equal(boba.health, 50);
            Assert.Equal(boba.strength, 5);
            Assert.Equal(boba.intelligence, 10);
            Assert.Equal(boba.stealth, 0);
            Assert.Equal(boba.agility, 0);
        }
        [Fact]
        public void TestFighterCreation()
        {
            Fighter leia = new Fighter();
            Assert.Equal(leia.name, "General Organa");
            Assert.Equal(leia.health, 100);
            Assert.Equal(leia.strength, 50);
            Assert.Equal(leia.intelligence, 15);
            Assert.Equal(leia.stealth, 5);
            Assert.Equal(leia.agility, 30);
        }
        [Fact]
        public void TestSmugglerCreation()
        {
            Smuggler nerfherder = new Smuggler();
            Assert.Equal(nerfherder.name, "Han Solo");
            Assert.Equal(nerfherder.health, 50);
            Assert.Equal(nerfherder.strength, 25);
            Assert.Equal(nerfherder.intelligence, 30);
            Assert.Equal(nerfherder.stealth, 50);
            Assert.Equal(nerfherder.agility, 20);
        }
        [Fact]
        public void TestJediCreation()
        {
            Jedi obiwan = new Jedi("Ben Kenobi");
            Assert.Equal(obiwan.name, "Ben Kenobi");
            Assert.Equal(obiwan.health, 50);
            Assert.Equal(obiwan.strength, 5);
            Assert.Equal(obiwan.intelligence, 10);
            Assert.Equal(obiwan.stealth, 0);
            Assert.Equal(obiwan.agility, 0);
        }
    }
}