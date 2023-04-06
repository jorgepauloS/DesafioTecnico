using Questao3.Models;
using System.Text.Json;

var faturamentos = JsonSerializer.Deserialize<List<Faturamento>>(File.OpenRead("dados.json"));

if (faturamentos != null)
{
    faturamentos.RemoveAll(e => e.Valor == 0);

    var min = faturamentos.MinBy(e => e.Valor);
    Console.WriteLine($"O menor faturamento foi {min.Valor} no dia {min.Dia}");

    var max = faturamentos.MaxBy(e => e.Valor);
    Console.WriteLine($"O maior faturamento foi {max.Valor} no dia {max.Dia}");

    var media = (faturamentos.Sum(e => e.Valor) / faturamentos.Count);
    Console.WriteLine($"Média mensal: {media}");

    Console.WriteLine($"Dias em que o faturamento foi maior do que a média mensal: {faturamentos.Where(e => e.Valor > media).Count()}");
}
else
{
    Console.WriteLine("Verifique o formato dos dados.");
}
