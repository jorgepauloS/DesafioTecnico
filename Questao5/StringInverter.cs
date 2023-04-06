using System.Text;

namespace Questao5
{
    public class StringInverter
    {
        public static string Inversao(string original)
        {
            Stack<char> chars = new(original);
            StringBuilder reversed = new();

            while (chars.Count > 0)
            {
                reversed.Append(chars.Pop());
            }

            return reversed.ToString();
        }
    }
}
