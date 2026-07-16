using SistemaBancario.APP.Interfaces;

namespace SistemaBancario.APP.Funcionarios
{
    public class Vendedor : Funcionario, IElegivelBonusNatalino
    {        
        public decimal ComissaoVendas { get; set; }
        
        public Vendedor(string nome, decimal salario, decimal comissaoVendas)
        {
            Nome = nome;
            SalarioBase = salario;
            ComissaoVendas = comissaoVendas;
            Cargo = "Vendedor";
            new ContaBancaria();
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
