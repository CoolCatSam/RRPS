using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RRSP_Shared_Classes;

namespace RRPS_Shared_Classes_Unit_Tests
{
    [TestClass]
    public class RPS_Types_Unit_Test
    {
        [TestMethod]
        public void TestCounterTypes()
        {
            Assert.AreEqual(RPS_Types.RPS_Type.PAPER, RPS_Types.GetWinningType(RPS_Types.RPS_Type.ROCK));
            Assert.AreEqual(RPS_Types.RPS_Type.ROCK, RPS_Types.GetWinningType(RPS_Types.RPS_Type.SCISSORS));
            Assert.AreEqual(RPS_Types.RPS_Type.SCISSORS, RPS_Types.GetWinningType(RPS_Types.RPS_Type.PAPER));

            Assert.AreEqual(RPS_Types.RPS_Type.PAPER, RPS_Types.GetLosingType(RPS_Types.RPS_Type.SCISSORS));
            Assert.AreEqual(RPS_Types.RPS_Type.ROCK, RPS_Types.GetLosingType(RPS_Types.RPS_Type.PAPER));
            Assert.AreEqual(RPS_Types.RPS_Type.SCISSORS, RPS_Types.GetLosingType(RPS_Types.RPS_Type.ROCK));

        }
    }
}
