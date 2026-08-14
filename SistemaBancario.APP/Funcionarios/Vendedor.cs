using SistemaBancario.APP.Contas;
using SistemaBancario.APP.Interfaces;

namespace SistemaBancario.APP.Funcionarios
{
    public class Vendedor : Funcionario, IElegivelBonusNatalino
    {        
        public decimal ComissaoVendas { get; set; }
        
        public Vendedor(string nome, decimal salario, decimal comissaoVendas, string departamento) : base(nome, "Vendedor", departamento)
        {            
            SalarioBase = salario;
            ComissaoVendas = comissaoVendas;            
        }
        
        public decimal CalcularBonusNatalino()
        {
            return CalcularSalario() * 0.02m;
        }
        public override decimal CalcularSalario()
        {
            return SalarioBase + ComissaoVendas;
        }
    }
}
