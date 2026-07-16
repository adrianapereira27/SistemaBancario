
using SistemaBancario.APP.Interfaces;

namespace SistemaBancario.APP
{
    public class Cliente : IRelatorio
    {
        public string Nome { get; set; }

        public string GerarRelatorio()
        {
            return $"Cliente: {Nome}";
        }
    }
}
