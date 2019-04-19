using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MasterMind.UnitTests
{
    [TestFixture]
    public class UserInputTests
    {
            //a valid response returns false because it breaks out of the while loop's condition
            [Test]
            public void UserInputReturnsFalseWhenInRange()
            {
                int num = 0;
                
                bool output = UserInput.NumberCheck("1234", out num);

                Assert.That(output, Is.False);
            }

            [Test]

            public void UserInputReturnsTrueWhenOutOfRange()
            {
                int num = 0;

                bool output = UserInput.NumberCheck("5678", out num);

                Assert.That(output, Is.True);
            }

            [Test]
            public void UserInputReturnsFalseWhenCorrectLength()
            {
                int num = 0;

                bool output = UserInput.NumberCheck("3333", out num);

                Assert.That(output, Is.False);
            }

            [Test]
            public void UserInputReturnsTrueWhenInputTooLong()
            {
                int num = 0;

                bool output = UserInput.NumberCheck("336633", out num);

                Assert.That(output, Is.True);
            }

            [Test]
            public void UserInputReturnsTrueWhenStringIsEntered()
            {
                int num = 0;

                bool output = UserInput.NumberCheck("squid", out num);

                Assert.That(output, Is.True);
            }

            [Test]
            public void UserInputReturnsTrueWhenInputTooShort()
            {
                int num = 0;

                bool output = UserInput.NumberCheck("12", out num);

                Assert.That(output, Is.True);
            }

    }
}
