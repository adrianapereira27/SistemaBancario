namespace SistemaBancario.API
{
    public class CartaoCredito : ITaxavel
    {
        public decimal LimiteUtilizado { get; set; }

        public decimal CalcularTaxa()
        {
            return LimiteUtilizado * 0.02m;
        }
    }
}
