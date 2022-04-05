using System.Globalization;

namespace ContaBancaria {
    class Conta {

        public int Numero { get;  private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public override string ToString() {
            return "Conta "
            + Numero
            + ", Titular: "            
            + Titular
            + ", Saldo: R$ "            
            + Saldo.ToString("f2", CultureInfo.InvariantCulture);
        }

        public Conta(int numero, string titular) {
            Numero = numero;
            Titular = titular;            
        }

        public Conta(int numero, string titular, double depositoInicial) : this(numero, titular) {
            Deposito(depositoInicial); // Saldo inical rebecendo como valor o método depósito.
        }
                
        public void Deposito(double deposito) {
            Saldo += deposito;
        }

        public void Saque(double saque) {
            Saldo -= saque + 5;
        }
    }
}
