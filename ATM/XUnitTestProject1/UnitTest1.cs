using Xunit;

namespace ATM
{
    public class TestDeposit
    {
        [Theory]
        [InlineData(10, 110)]
        [InlineData(11, 111)]
        [InlineData(12, 112)]

        public void Test1(int a, int b)
        {
            double x = Program.Deposit(a);
            Assert.Equal(b, x);
            Program.balance = 100;
        }

        [Theory]
        [InlineData(10, "pass")]
        [InlineData(11, "pass")]
        [InlineData(500, "fail")]

        public void Test2(int a, string b)
        {
            string x = Program.Withdraw(a);
            Assert.Equal(b, x);
            Program.balance = 100;
        }

        [Theory]
        [InlineData(-10)]
        [InlineData(-11)]
        [InlineData(-50)]

        public void Test3(int a)
        {
            double x = Program.Deposit(a);
            double y = Program.balance;
            Assert.Equal(y, x);
        }
    }
}
