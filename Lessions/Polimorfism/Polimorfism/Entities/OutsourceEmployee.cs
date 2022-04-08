using System.Globalization;

namespace Polimorfism.Entities
{
    class OutsourceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourceEmployee()
        {
        }

        public OutsourceEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + AdditionalCharge * 1.1;
        }

        public override string ToString()
        {
            return Name
                + " - $ "
                + Payment().ToString("f2", CultureInfo.InvariantCulture)
                + " --> Outsourced Employee!";
        }
    }
}
