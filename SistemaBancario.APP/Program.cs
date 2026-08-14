using SistemaBancario.APP;
using SistemaBancario.APP.Contas;
using SistemaBancario.APP.Funcionarios;
using SistemaBancario.APP.Interfaces;
using System.Linq;

List<ITaxavel> itens = new List<ITaxavel> { new ContaPoupanca(), new CartaoCredito() };

foreach (var item in itens)
{
    //Console.WriteLine("Taxa: " + item.CalcularTaxa());
    Console.WriteLine($"Taxa: {item.CalcularTaxa():C}");  // interpolação é mais usado, :C é para converter o valor em moeda (R$ 0,00)
}

List<IRelatorio> relat = new List<IRelatorio> { new ContaBancaria(), new Cliente() };
foreach (var item in relat)
{
    Console.WriteLine(item.GerarRelatorio()); // cada um chama SUA própria versão
}

ContaBancaria cb = new ContaBancaria();
Console.WriteLine(cb.GerarExtrato());


List<Funcionario> func = new List<Funcionario> {
    new Vendedor("João", 2300.00m, 300.00m, "Comercial"),
    new Vendedor("Rafael", 2400.00m, 400.00m, "Comercial"),
    new Gerente("Pedro", 3000.00m, 500.00m, "TI"),
    new Gerente("Jorge", 3200.00m, 470.00m, "RH"),
    new Estagiario("Lucas", 1600.00m, "TI"),
    new Estagiario("Ricardo", 1700.00m, "RH")
};

var somaTotalSalarios = func.Where(f => f.Departamento == "RH").Sum(f => f.CalcularSalario());
Console.WriteLine($"Total de todos os salarios de um departamento é {somaTotalSalarios:C}");

var nomesFuncs = func.Where(f => f.Departamento == "Comercial").Select(f => f.Nome);
Console.WriteLine($"Funcionários do departamento: {string.Join(",", nomesFuncs)}");


var funcionariosComBonus = func.Where(f => f is IElegivelBonusNatalino);  // LINQ
var nomesFuncionarios = func.Select(f => f.Nome);   // LINQ
var totalFolhaPagamento = func.Sum(f => f.CalcularSalario());   // LINQ

Console.WriteLine($"Funcionários com bonus: {string.Join(",", funcionariosComBonus.Select(f => f.Nome))}");
Console.WriteLine($"Todos os funcionários: {string.Join(",", nomesFuncionarios)}");
Console.WriteLine($"Total de todos os salarios é {totalFolhaPagamento:C}");
Console.WriteLine($"{string.Join(",", func.Where(f => f is Vendedor))}");

foreach (var item in func)
{
    Console.WriteLine($"{item.Identificar()} - Salario: {item.CalcularSalario():C}");
    item.PagarSalario();
    Console.WriteLine(item.Conta.GerarRelatorio());
    if (item is IElegivelBonusNatalino minhaInterface)
    {
        Console.WriteLine($"Bonus Natalino: {minhaInterface.CalcularBonusNatalino():C}");
    }
}
