using System;
using Xunit;
using ATM;

namespace ATM_Tests
{
    public class Tests
    {
        [Fact]
        public void BalanceEquals300()
        {
            ATMApp.balance = 300.00m;
            // Action
            decimal result = ATMApp.ViewBalance();
            string final = result.ToString();

            //Assertion
            Assert.Equal("300.00", final);
        }

        [Fact]
        public void BalanceDoesNotEqual15()
        {
            ATMApp.balance = 300.00m;

            decimal result = ATMApp.ViewBalance();
            string final = result.ToString();

            Assert.NotEqual("15", final);
        }

        [Fact]
        public void BalanceEquals280()
        {
            ATMApp.balance = 300.00m;

            decimal result = ATMApp.Withdraw(20);
            string final = result.ToString();

            Assert.Equal("280.00", final);
        }

        [Fact]
        public void BalanceNotNegative()
        {
            ATMApp.balance = 300.00m;

            decimal result = ATMApp.Withdraw(350);
            string final = result.ToString();

            Assert.NotEqual("-50.00", final);

        }

        [Fact]
        public void BalanceEquals320()
        {
            ATMApp.balance = 300.00m;

            decimal result = ATMApp.Deposit(20);
            string final = result.ToString();

            Assert.Equal("320.00", final);
        }

        [Fact]
        public void DepositNotNegative()
        {
            ATMApp.balance = 300.00m;

            decimal result = ATMApp.Deposit(-20);
            string final = result.ToString();

            Assert.NotEqual("320.00", final);
        }
    }
}
