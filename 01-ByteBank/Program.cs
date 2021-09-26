using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciando a classe 
            ContaCorrente conta = new ContaCorrente();
            conta.titular = "Gabriela";
            conta.numero = 863452;
            conta.numeroagencia = 863;
            conta.saldo = 100;
            Console.WriteLine(conta.titular);
            Console.ReadLine();
        }
    }
}
