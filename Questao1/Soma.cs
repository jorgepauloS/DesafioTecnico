namespace Questao1
{
    public class Soma
    {
        public static int RetornaSoma()
        {
            int indice = 13, soma = 0, k = 0;

            while (k < indice)
            {
                k++;
                soma += k;
            }

            return soma;
        }
    }
}
