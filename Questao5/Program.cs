using Questao5;

Console.WriteLine("Digite o texto a ser invertido: ");
string? original = Console.ReadLine();
while (string.IsNullOrEmpty(original))
{
    Console.WriteLine("Texto não reconhecido, tente novamente.");
    original = Console.ReadLine();
}

Console.WriteLine(StringInverter.Inversao(original));