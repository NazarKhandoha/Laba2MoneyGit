﻿using System;

namespace Purse
{
    class Program
    {
        static void Main(string[] args)
        {
			//In this file we have conflicts
            var money = new Money.Money(100);
            Console.WriteLine(money.GetMoney());
            var credit = new CreditCard.CreditCard(500);
            Console.WriteLine(credit.GetSumCreditCard());
            var bcard = new BusinessCard.BusinessCard("My business Nazar Volodymyrovych  say  ");
			
            Console.WriteLine(bcard.FindOutWhose());
        }
    }
}
