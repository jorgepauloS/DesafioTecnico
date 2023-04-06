using Questao3;
using Questao3.Models;
using System.Text.Json;

var faturamentos = JsonSerializer.Deserialize<List<Faturamento>>(File.OpenRead("dados.json"));

if (faturamentos != null)
{
    Auxiliaries.RemoveFaturamentoZerado(ref faturamentos);

    var min = Auxiliaries.Minimo(faturamentos);
    Console.WriteLine($"O menor faturamento foi {min.Valor} no dia {min.Dia}");

    var max = Auxiliaries.Maximo(faturamentos);
    Console.WriteLine($"O maior faturamento foi {max.Valor} no dia {max.Dia}");

    var media = Auxiliaries.Media(faturamentos);
    Console.WriteLine($"Média mensal: {media}");

    Console.WriteLine($"Dias em que o faturamento foi maior do que a média mensal: {Auxiliaries.DiasFaturamentoMaiorQueMedia(faturamentos)}");
}
else
{
    Console.WriteLine("Verifique o formato dos dados.");
}
