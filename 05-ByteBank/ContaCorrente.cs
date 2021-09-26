using _05_ByteBank;

namespace _05_ByteBank
{
    class ContaCorrente
    {   // cuidar o namespace
        public Cliente titular;
        public int numeroagencia;
        public int numero;
        public double saldo = 100;

        public bool Sacar(double pValor)
        {
            if (this.saldo < pValor)
            {
                return false;
            }
            else
            {
                this.saldo = this.saldo - pValor;
                return true;
            }
        }

        public void Depositar(double pValor)
        {
            this.saldo += pValor;
        }

        public bool Transferir(double pValor, ContaCorrente pContaDestino)
        {

            if (this.saldo < pValor)
            {
                return false;
            }
            else
            {
                // tira da conta atual 
                this.saldo -= pValor;
                // altera conta destino
                pContaDestino.Depositar(pValor);
                return true;
            }

        }



    }

}