using System;
using System.Collections.Generic;
using Xunit;
using starwars;


namespace test
{
    public class UnitTest1
    {
        Sith helmet = new Sith("Vader");
        Jedi obiwan = new Jedi("Ben Kenobi");

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

        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(8)]
        [InlineData(10)]
        [InlineData(17)]
        [InlineData(20)]
        public void TestEnemyGen2To20(int turn)
        {
            List<starwars.Humanoid> enemyList = Program.enemyGen(turn);
            if(turn < 2)
            {
                Assert.Equal(enemyList.Count, 1);
                Assert.Equal(enemyList[0].GetType(), typeof(StormTrooper));
            }
            else if(turn < 10)
            {
                Assert.Equal(enemyList.Count, 2);
                Assert.Equal(enemyList[0].GetType(), typeof(StormTrooper));
                Assert.Equal(enemyList[1].GetType(), typeof(StormTrooper));
            }
            else if(turn == 10)
            {
                Assert.Equal(enemyList.Count, 2);
                Assert.Equal(enemyList[0].GetType(), typeof(BountyHunter));
                Assert.Equal(enemyList[1].GetType(), typeof(StormTrooper));  
            }
            else if (turn < 20) 
            {
                Assert.Equal(enemyList.Count, 3);
                Assert.Equal(enemyList[0].GetType(), typeof(BountyHunter));
                Assert.Equal(enemyList[1].GetType(), typeof(StormTrooper));
                Assert.Equal(enemyList[2].GetType(), typeof(StormTrooper));                
            }
            else if(turn == 20)
            {
                Assert.Equal(enemyList.Count, 3);
                Assert.Equal(enemyList[0].GetType(), typeof(Sith));
                Assert.Equal(enemyList[1].GetType(), typeof(StormTrooper));
                Assert.Equal(enemyList[2].GetType(), typeof(StormTrooper));
            }
        }
    }
}
