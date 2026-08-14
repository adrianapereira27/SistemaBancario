using SistemaBancario.APP.Contas;

namespace SistemaBancario.APP.Funcionarios
{
    public class Estagiario : Funcionario
    {
        public Estagiario(string nome, decimal salario, string departamento) : base(nome, "Estagiário", departamento)
        {            
            SalarioBase = salario; 
        }
        
        public override decimal CalcularSalario()
        {
            return SalarioBase;
        }
    }
}
