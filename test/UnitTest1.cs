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
    }
}
