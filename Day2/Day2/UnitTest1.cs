using NUnit.Framework;
using Puzzle;
namespace Day2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string[] lines = System.IO.File.ReadAllLines(@"Input.txt");
            Assert.AreEqual(460, Program.CountValidPassword(lines));
        }

        [Test]
        public void Test2()
        {
            string[] lines = { "2-5 z: zzztvz", "2-8 d: pddzddkdvqgxndd" };
            Assert.AreEqual(2, Program.CountValidPassword(lines));
        }

    }
}