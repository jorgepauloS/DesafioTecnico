namespace Questao4
{
    public class Calculadora
    {
        private readonly Dictionary<string, double> faturamentos = new();

        public void AddFaturamento(string estado, double valor)
        {
            faturamentos.Add(estado, valor);
        }

        public double Total()
        {
            return faturamentos.Values.Sum();
        }

        public double Porcentagem(string estado)
        {
            return faturamentos[estado] / Total() * 100;
        }

        public List<string> Estados()
        {
            return faturamentos.Keys.ToList();
        }
    }
}
