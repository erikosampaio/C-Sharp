namespace Taxpayer.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployee { get; set; }

        public Company()
        {
        }

        public Company(string name, double anualIncome, int numberOfEmployee)
            : base(name, anualIncome)
        {
            NumberOfEmployee = numberOfEmployee;
        }

        public override double TaxesPaid()
        {
            if (NumberOfEmployee > 10)
            {
                return AnualIncome * 0.14;
            }
            return AnualIncome * 0.16;
        }
    }
}
