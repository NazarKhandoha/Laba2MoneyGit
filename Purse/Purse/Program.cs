﻿using System;

namespace Purse
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = new Money.Money(100);
            Console.WriteLine(money.GetMoney());
            var credit = new CreditCard.CreditCard(500);
            Console.WriteLine(credit.GetSumCreditCard());
            var bcard = new BusinessCard.BusinessCard("My business NazarKhandoha say ");
            Console.WriteLine(bcard.FindOutWhose());
        }
    }
}
