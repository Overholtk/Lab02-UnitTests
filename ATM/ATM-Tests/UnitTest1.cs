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

            // Action
            decimal result = ATMApp.ViewBalance();
            string final = result.ToString();

            //Assertion
            Assert.Equal("300.00", final);
        }

        [Fact]
        public void BalanceDoesNotEqual15()
        {
            decimal result = ATMApp.ViewBalance();
            string final = result.ToString();

            Assert.NotEqual("15", final);
        }

        [Fact]
        public void BalanceEquals280()
        {
            decimal result = ATMApp.Withdraw(20);
            string final = result.ToString();

            Assert.Equal("280.00", final);
        }

        [Fact]
        public void BalanceNotNegative()
        {
            decimal result = ATMApp.Withdraw(350);
            string final = result.ToString();

            Assert.NotEqual("-50.00", final);

        }

        [Fact]
        public void BalanceEquals320()
        {
            decimal result = ATMApp.Deposit(20);
            string final = result.ToString();

            Assert.Equal("320.00", final);
        }

        [Fact]
        public void DepositNotNegative()
        {
            decimal result = ATMApp.Deposit(-20);
            string final = result.ToString();

            Assert.NotEqual("320.00", final);
        }
    }
}
