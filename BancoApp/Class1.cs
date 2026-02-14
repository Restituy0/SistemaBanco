namespace BancoApp
{
    public class Cuenta
    {
        public decimal Saldo { get; private set; }

        public Cuenta(decimal saldoInicial)
        {
            Saldo = saldoInicial;
        }

        public bool Transferir(decimal monto)
        {
            if (monto <= 0)
                return false;

            if (Saldo >= monto)
            {
                Saldo -= monto;
                return true;
            }

            return false;
        }
    }
}
