using SistemaBancario.APP.Contas;
using SistemaBancario.APP.Interfaces;

namespace SistemaBancario.APP.Funcionarios
{
    public class Gerente : Funcionario, IElegivelBonusNatalino
    {
        public decimal Bonus { get; set; }

        public Gerente(string nome, decimal salario, decimal bonus, string departamento) : base(nome, "Gerente", departamento)
        {            
            SalarioBase = salario;
            Bonus = bonus;
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
