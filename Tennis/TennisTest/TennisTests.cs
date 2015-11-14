﻿using NUnit.Framework;
using Tennis;

namespace TennisTest
{
    [TestFixture]
    public class TennisTests
    {
        [Test]
        public void GetScore_Shouldbe_LOVE_LOVE_When_Input_0_0()
        {
            Assert.AreEqual("LOVE-LOVE", Tennis.Tennis.GetScore(0, 0));
        }

        [Test]
        public void GetScore_Shouldbe_15_LOVE_When_Input_1_0()
        {
            Assert.AreEqual("15-LOVE",Tennis.Tennis.GetScore(1,0));
        }

        [Test]
        public void GetScore_Shouldbe_15_All_When_Input_1_1()
        {
            Assert.AreEqual("15-ALL",Tennis.Tennis.GetScore(1,1));
        }

        [Test]
        public void GetScore_Shouldbe_30_15_When_Input_2_1()
        {
            Assert.AreEqual("30-15", Tennis.Tennis.GetScore(2, 1)); 
        }

        [Test]
        public void GetScore_ShouldBe_30_ALL_When_Input_2_2()
        {
            Assert.AreEqual("30-ALL", Tennis.Tennis.GetScore(2, 2));
        }

        [Test]
        public void GetScore_ShouldBe_40_30_When_Input_3_2()
        {
            Assert.AreEqual("40-30", Tennis.Tennis.GetScore(3, 2));
        }

        [Test]
        public void GetScore_ShouldBe_DEUCE_When_Input_3_3()
        {
            Assert.AreEqual("DEUCE", Tennis.Tennis.GetScore(3, 3)); 
        }
    }
}
