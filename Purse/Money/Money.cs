namespace Money
{
    public class Money
    {
        private decimal amount = 0;
        private string msg = "It's my money";
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
