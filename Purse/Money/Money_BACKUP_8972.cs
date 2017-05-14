namespace Money
{
    public class Money
    {
        private decimal amount = 0;
<<<<<<< HEAD
        private string msg = "Money";
=======
        private string msg = "Nazar Khandoha";
>>>>>>> FeatureBranch
        public string GetMoney()
        {
            return msg + amount.ToString();
        }
        public Money(decimal amount)
        {
            this.amount = amount;
        }
    }
}
