using SistemaBancario.APP.Interfaces;

namespace SistemaBancario.APP.Contas
{
    public class ContaBancaria : IRelatorio
    {
        public decimal Saldo { get; protected set; }
        private GeradorPdf _geradorPdf = new GeradorPdf();   // composição: "TEM UM" gerador

        protected void ValidarValorPositivo(decimal valor)
        {
            if (valor <= 0)
                throw new ArgumentOutOfRangeException(nameof(valor), "Valor deve ser positivo");
        }
        public string GerarExtrato()
        {
            return _geradorPdf.Gerar($"Extrato - Saldo: {Saldo:C}");
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
        public string GerarRelatorio()
        {
            return $"Saldo atual: {Saldo:C}";
        }

    }
}
