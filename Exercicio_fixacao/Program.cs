using System.Globalization;
using System;

namespace Exercicio_fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;
            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)?");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre o valor depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                   conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            
            

            //Colocar na tela os dados da conta:
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            
            Console.WriteLine(conta);
            //DEPÓSITO:
            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            //Atualização
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
            //SAQUE:
            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine());
            conta.Saque(quantia);
            //Atualização de dados
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);



            Console.ReadKey();

        }
    }
}
