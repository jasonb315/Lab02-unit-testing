using System;
using Xunit;

namespace ATM
{
    public class UnitTest1
    {
        [Fact]

        public void Test1()
        {
            double x = Program.Deposit(10);
            Assert.Equal(110, x);
        }
    }
}
