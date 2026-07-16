namespace SistemaBancario.API
{
    public class ContaPoupanca : ContaBancaria, ITaxavel
    {
        public decimal TaxaRendimento { get; set; } = 0.005m;
        private int saquesNoMes = 0;

        public void AplicarRendimento()
        {
            Depositar(Saldo * TaxaRendimento);
        }

        public override void Sacar(decimal valor)
        {           
            if (saquesNoMes >= 1)
                throw new InvalidOperationException("Poupança permite apenas 1 saque por mês");

            base.Sacar(valor);   // reaproveita a validação de saldo insuficiente da classe mãe
            saquesNoMes++;
        }

        public decimal CalcularTaxa()
        {
            return Saldo * 0.001m;
        }
    }
}
