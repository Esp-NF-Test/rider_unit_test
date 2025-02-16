using System;
using NUnit.Framework;

namespace TestProject2
{
    [TestFixture]
    public class Tests
    {
        private Calculator _calculator = new Calculator();

        [Test]
        public void first_1_second_2_add_should_return_3()
        {
            ResultShouldBe(3, 1, 2);
        }

        private void ResultShouldBe(int expected, int first, int second)
        {
            Assert.AreEqual(expected, _calculator.Add(first, second));
        }
    }
}