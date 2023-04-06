Console.WriteLine("Digite o número que deseja verificar se pertence à sequência de Fibonnaci: ");

int pivot;
while (!int.TryParse(Console.ReadLine(), out pivot))
{
    Console.WriteLine("Número inválido, tente novamente.");
}

int fibonacciTotal = 0;
(int fibonacciA, int fibonacciB) = (0, 1);

bool pivotPertenceFibonnaci = false;

while (pivot > fibonacciTotal)
{
    fibonacciTotal = fibonacciA + fibonacciB;
    fibonacciA = fibonacciB;
    fibonacciB = fibonacciTotal;

    if (pivot == fibonacciTotal)
    {
        pivotPertenceFibonnaci = true;
        break;
    }
}

if (pivotPertenceFibonnaci)
{
    Console.WriteLine("O número informado pertence à sequência de Fibonnaci.");
}
else
{
    Console.WriteLine("O número informado não pertence à sequência de Fibonnaci.");
}