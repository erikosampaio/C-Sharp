namespace Taxpayer.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double anualIncome, double healthExpenditures)
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double TaxesPaid()
        {
            if (AnualIncome < 20000.0)
            {
                if (HealthExpenditures > 0)
                {
                    double taxesPaid = AnualIncome * 0.15;
                    return taxesPaid - HealthExpenditures * 0.5;
                }
                else
                {
                    double taxesPaid = AnualIncome * 0.15;
                    return taxesPaid;
                }
            }
            else if (HealthExpenditures > 0)
            {
                double taxesPaid = AnualIncome * 0.25;
                return taxesPaid - HealthExpenditures * 0.5;
            }
            else
            {
                return AnualIncome * 0.25;
            }
        }
    }
}
