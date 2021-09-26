using _06_ByteBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06__ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente Conta = new ContaCorrente();
            Cliente cliente = new Cliente();
            cliente.Nome = "Guilherme";
            cliente.CFP = "848.779.600-15";
            cliente.Profissao = "Desenvolvedor";

            Conta.Titular = cliente;
            Conta.Saldo = -10;
            Console.WriteLine(Conta.Titular.Nome);
            Console.WriteLine(Conta.Saldo);
            Console.ReadLine();
        }
    }
}
