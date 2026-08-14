using SistemaBancario.APP.Contas;

namespace SistemaBancario.APP.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public decimal SalarioBase { get; set; }
        public ContaBancaria Conta {  get; set; }
        public string Departamento { get; set; }

        public Funcionario(string nome, string cargo, string departamento) 
        {
            Nome = nome;
            Cargo = cargo;
            Departamento = departamento;
            Conta = new ContaBancaria();           
        }

        public override string ToString()
        {
            return $"{Cargo}: {Nome}";
        }
        // Métodos concretos: já vem pronto, todas as filhas herdam igual
        public string Identificar()
        {
            return $"Funcionário: {Nome} - Cargo: {Cargo}";
        }
        public void PagarSalario()
        {
            Conta.Depositar(CalcularSalario());            
        }
        // Método abstrato: SEM corpo, cada filha é OBRIGADA a implementar do seu jeito
        public abstract decimal CalcularSalario();
                
    }
}
