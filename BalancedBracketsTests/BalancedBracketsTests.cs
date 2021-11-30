using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }


        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void EmptyStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }


        [TestMethod]
        public void NoBracketAtAllReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("LaunchCode"));
        }

        [TestMethod]
        public void SingleBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }

        [TestMethod]
        public void OnlyClosingBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
        }

        [TestMethod]
        public void StringInsideBracketReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[ or ]"));
        }


        


        [TestMethod]
        public void BracketAfterWordReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Launch[Code]"));
        }


        [TestMethod]
        public void BracketBeforeWordReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]LaunchCode"));
        }


        [TestMethod]
        public void TwoSetsOfBracketsReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]LaunchCode[]"));
        }


        [TestMethod]
        public void BracketSetsAroundWordReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[LaunchCode]]"));
        }

        [TestMethod]
        public void SingleBracketWithWordReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[LaunchCode"));
        }

        [TestMethod]
        public void UnbalancedBracketsReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }
    }
}
