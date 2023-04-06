using System.Text;

Console.WriteLine("Digite o texto a ser invertido: ");
string? original = Console.ReadLine();
while (string.IsNullOrEmpty(original))
{
    Console.WriteLine("Texto não reconhecido, tente novamente.");
    original = Console.ReadLine();
}

Stack<char> chars = new(original);
StringBuilder reversed = new();

while (chars.Count > 0)
{
    reversed.Append(chars.Pop());
}

Console.WriteLine(reversed.ToString());