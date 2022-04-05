using System.Globalization;

namespace ListEmployee {
    class Employee {

        public int Id { get; private set; }
        public string Name { get; private set; }
        public double Salary { get; private set; }
        

        public Employee(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }

        override public string ToString() {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("f2", CultureInfo.InvariantCulture);
        }
        
        
        public void increaseSalary(double percentage) {
            Salary += Salary * percentage / 100;
        }
    }
}
