using _06_ByteBank;

namespace _06_ByteBank
{
    class ContaCorrente
    {   // cuidar o namespace
        private Cliente _titular;
        public int _numeroagencia;
        public int _numero;
        private double _saldo = 100;

        public Cliente Titular{ get;set;}

        public int Agencia { get; set; }

        public int Numero { get; set; }


        public double Saldo 
        {
            get 
            {
                return _saldo;
            }
            set 
            {
                if (value < 0)
                {
                    return; // pode por ser void ()
                }
                // certinho 
                _saldo = value;
            }
        }


        public bool Sacar(double pValor)
        {
            if (this._saldo < pValor)
            {
                return false;
            }
            else
            {
                this._saldo = this._saldo - pValor;
                return true;
            }
        }

        public void Depositar(double pValor)
        {
            this._saldo += pValor;
        }

        public bool Transferir(double pValor, ContaCorrente pContaDestino)
        {

            if (this._saldo < pValor)
            {
                return false;
            }
            else
            {
                // tira da conta atual 
                this._saldo -= pValor;
                // altera conta destino
                pContaDestino.Depositar(pValor);
                return true;
            }

        }



    }

}