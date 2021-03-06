namespace Heritage.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance) // Linha que herda o construtor da superclasse (Account)
        {
            LoanLimit = loanLimit; // Acrescentando mais um atributo para o contrutor da classe BusinessAccount
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
