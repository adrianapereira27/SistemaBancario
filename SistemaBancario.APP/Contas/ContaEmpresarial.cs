namespace SistemaBancario.APP.Contas
{
    public class ContaEmpresarial : ContaBancaria
    {
        public decimal LimiteChequeEspecial { get; set; } = 800.00m;

                
        public override void Sacar(decimal valor)
        {
            ValidarValorPositivo(valor);

            if (Saldo - valor < -LimiteChequeEspecial)
                throw new InvalidOperationException("Limite do cheque especial excedido");

            Saldo -= valor;
        }
    }
}
