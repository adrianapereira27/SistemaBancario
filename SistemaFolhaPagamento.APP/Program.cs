using SistemaFolhaPagamento.APP;
using System.Linq;

List<Funcionario> itens = new List<Funcionario> { 
    new Vendedor("João", 2300.00m, 300.00m), 
    new Vendedor("Rafael", 2400.00m, 400.00m), 
    new Gerente("Pedro", 3000.00m, 500.00m), 
    new Estagiario("Lucas", 1600.00m) 
};

var funcionariosComBonus = itens.Where(f => f is IElegivelBonusNatalino);  // LINQ

var nomesFuncionarios = itens.Select(f => f.Nome);   // LINQ

var totalFolhaPagamento = itens.Sum(f => f.CalcularSalario());   // LINQ

Console.WriteLine($"Funcionários com bonus: {string.Join(",", funcionariosComBonus.Select(f => f.Nome))}");
Console.WriteLine($"Todos os funcionários: { string.Join(",", nomesFuncionarios)}");
Console.WriteLine($"Total de todos os salarios é {totalFolhaPagamento:C}");
Console.WriteLine($"{string.Join(",", itens.Where(f => f is Vendedor))}");

foreach (var item in itens)
{    
    Console.WriteLine($"{item.Identificar()} - Salario: {item.CalcularSalario():C}");
    item.PagarSalario();
    Console.WriteLine(item.Conta.GerarRelatorio());
    if (item is IElegivelBonusNatalino minhaInterface)
    {        
        Console.WriteLine($"Bonus Natalino: {minhaInterface.CalcularBonusNatalino():C}");
    }
}

