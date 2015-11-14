using NUnit.Framework;
using System.Collections.Generic;
using Tennis;

namespace TennisTest
{
    [TestFixture]
    public class TennisTests
    {
        [SetUp]
        public void Init()
        {
            Tennis.Tennis.GameRuleList = new List<GameRule>()
            {
                new DeuceRule(), 
                new StartGameRule(),
                new EqualScoreRule()
            };
        }

        [Test]
        public void GetResult_Shouldbe_LOVE_LOVE_When_Input_0_0()
        {
            Assert.AreEqual("LOVE-LOVE", Tennis.Tennis.GetResult(0, 0));
        }

        [Test]
        public void GetResult_Shouldbe_15_LOVE_When_Input_1_0()
        {
            Assert.AreEqual("15-LOVE",Tennis.Tennis.GetResult(1,0));
        }

        [Test]
        public void GetResult_Shouldbe_15_All_When_Input_1_1()
        {
            Assert.AreEqual("15-ALL",Tennis.Tennis.GetResult(1,1));
        }

        [Test]
        public void GetResult_Shouldbe_30_15_When_Input_2_1()
        {
            Assert.AreEqual("30-15", Tennis.Tennis.GetResult(2, 1)); 
        }

        [Test]
        public void GetResult_ShouldBe_30_ALL_When_Input_2_2()
        {
            Assert.AreEqual("30-ALL", Tennis.Tennis.GetResult(2, 2));
        }

        [Test]
        public void GetResult_ShouldBe_40_30_When_Input_3_2()
        {
            Assert.AreEqual("40-30", Tennis.Tennis.GetResult(3, 2));
        }

        [Test]
        public void GetResult_ShouldBe_DEUCE_When_Input_3_3()
        {
            Assert.AreEqual("DEUCE", Tennis.Tennis.GetResult(3, 3)); 
        }

        [Test]
        public void GetResult_ShouldBe_ADVANTAGE_A_When_Input_4_3()
        {
            Assert.AreEqual("ADVANTAGE-A", Tennis.Tennis.GetResult(4, 3));
        }

        [Test]
        public void GetResult_ShouldBe_GAME_FOR_A_When_Input_5_3()
        {
            Assert.AreEqual("GAME FOR A", Tennis.Tennis.GetResult(5, 3));
        }
    }
}
