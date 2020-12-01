using NUnit.Framework;
using Puzzle;

namespace Day1
{
    public class Tests
    {
        [Test]
        public void ShouldBeMatchTo2020()
        {
            Assert.AreEqual(436404, Puzzle.Program.FindSumOfTwoNumbers(2020));
        }

        [Test]
        public void ShouldBeMatchTo2010()
        {
            Assert.AreEqual(929369, Program.FindSumOfTwoNumbers(2010));
        }
    }
}