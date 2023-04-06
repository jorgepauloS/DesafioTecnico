namespace Questao2
{
    public class Fibonnaci
    {
        public static bool PivotFibonnaciSequence(int pivot)
        {
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

            return pivotPertenceFibonnaci;
        }
    }
}
