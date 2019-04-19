using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MasterMind.UnitTests
{
    [TestFixture]
    public class OpponentCodeTests
    {
        [Test]
        public void RandomNumbersAreWithinRange()
        {
            List<int> invalidNumbers = new List<int>();

            invalidNumbers.Add(0);
            invalidNumbers.Add(7);
            invalidNumbers.Add(8);
            invalidNumbers.Add(9);

            int code = OpponentCode.GenerateRandomCode();

            foreach (var num in invalidNumbers)
            {
                Assert.That(code, Does.Not.Contain(num));
            }
        }

        [Test]
        public void CodeIsFourNumbersInLength()
        {
            int code = OpponentCode.GenerateRandomCode();

            Assert.That(code.ToString().Count, Is.EqualTo(4));
        }

        [Test] 
        public void CodeIsAnInt32()
        {
            int code = OpponentCode.GenerateRandomCode();

            Assert.That(code.GetType().ToString(), Is.EqualTo("System.Int32"));
        }
    }
}
