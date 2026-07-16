namespace SistemaBancario.API
{
    public class ContaBancaria
    {
        public decimal Saldo { get; protected set; }

        protected void ValidarValorPositivo(decimal valor)
        {
            if (valor <= 0)
                throw new ArgumentOutOfRangeException(nameof(valor), "Valor deve ser positivo");
        }

        public void Depositar(decimal valor)
        {
            ValidarValorPositivo(valor);            
            Saldo += valor;
        }
        public virtual void Sacar(decimal valor)
        {
            ValidarValorPositivo(valor);
            if (valor > Saldo)            
                throw new InvalidOperationException("Saldo insuficiente");           
            Saldo -= valor;
        }
          
    }
}
