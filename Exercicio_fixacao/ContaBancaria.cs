using System.Globalization;
namespace Exercicio_fixacao {
    class ContaBancaria {
        //número da conta pode ser acessado, mas não alterado
        public int Numero {get; set;}
        public string Titular {get; set;}
        public double Saldo {get; private set;}
        public int ClienteId { get; set; }

        //criando construtor com 2 argumentos: 
        public ContaBancaria(int numero, string titular) {
            Numero = numero;
            Titular = titular;

        }

        //criando construtor com 3 argumentos: 
        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular) {
            Deposito(depositoInicial);
        }

        //adicionando método para Depósito: 
        public void Deposito(double quantia) {
            Saldo += quantia;
        }

        //adicionando método para Saque:
        public void Saque(double quantia) {
            Saldo -= quantia;
            //Taxa de 5 reais para cada saque!
            Saldo -= 5.0;
        }

        //tostring para ver na tela: 
        public override string ToString() {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }



}
