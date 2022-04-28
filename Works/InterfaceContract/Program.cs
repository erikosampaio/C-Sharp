using InterfaceContract.Entities;
using InterfaceContract.Services;
using System;
using System.Globalization;

namespace InterfaceContract
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int numberContract = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");            
            DateTime dateTimeContract = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double valueContract = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract contract = new Contract(numberContract, dateTimeContract, valueContract);

            ContractService contractService = new ContractService(new PayPalService());
            contractService.ContractProcess(contract, months);

            Console.WriteLine("Installments: ");
            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
