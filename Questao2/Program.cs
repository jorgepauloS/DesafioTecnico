Console.WriteLine("Digite o número que deseja verificar se pertence à sequência de Fibonnaci: ");

int pivot;
while (!int.TryParse(Console.ReadLine(), out pivot))
{
    Console.WriteLine("Número inválido, tente novamente.");
}

if (Questao2.Fibonnaci.PivotFibonnaciSequence(pivot))
{
    Console.WriteLine("O número informado pertence à sequência de Fibonnaci.");
}
else
{
    Console.WriteLine("O número informado não pertence à sequência de Fibonnaci.");
}