using Questao4;

var calc = new Calculadora();

calc.AddFaturamento("SP", 67836.43);
calc.AddFaturamento("RJ", 36678.66);
calc.AddFaturamento("MG", 29229.88);
calc.AddFaturamento("ES", 27165.48);
calc.AddFaturamento("Outros", 19849.53);

Console.WriteLine($"Total: {calc.Total()}");

foreach (string estado in calc.Estados())
{
    Console.WriteLine($"{estado}: {calc.Porcentagem(estado)}%");
}
