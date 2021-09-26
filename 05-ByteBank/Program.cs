using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {    // criando um cliente 
            Cliente gabriel = new Cliente();
            gabriel.nome = "Gabriela";
            gabriel.profissao = "Desenvolvedora C#";
            gabriel.cpf = "84877960015";

            ContaCorrente conta = new ContaCorrente();
            conta.titular = gabriel;
            conta.saldo = 500;
            conta.numeroagencia = 563;
            conta.numero = 5634527;

            Console.WriteLine(gabriel.nome);
            Console.WriteLine(conta.titular.nome);
            Console.ReadLine();

        }
    }
}
