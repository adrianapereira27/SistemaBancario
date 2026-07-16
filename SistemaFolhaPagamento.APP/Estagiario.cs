
namespace SistemaFolhaPagamento.APP
{
    public class Estagiario : Funcionario
    {
        public Estagiario(string nome, decimal salario)
        {
            Nome = nome;
            SalarioBase = salario;
            Cargo = "Estagiario";
            new ContaBancaria();
        }
        
        public override decimal CalcularSalario()
        {
            return SalarioBase;
        }
    }
}
