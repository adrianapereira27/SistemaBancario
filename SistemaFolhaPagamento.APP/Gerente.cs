
namespace SistemaFolhaPagamento.APP
{
    public class Gerente : Funcionario, IElegivelBonusNatalino
    {
        public decimal Bonus { get; set; }

        public Gerente(string nome, decimal salario, decimal bonus)
        {
            Nome = nome;
            SalarioBase = salario;
            Bonus = bonus;
            Cargo = "Gerente";            
        }
        
        public decimal CalcularBonusNatalino()
        {
            return CalcularSalario() * 0.02m;
        }
        public override decimal CalcularSalario()
        {
            return SalarioBase + Bonus;
        }
    }
}
