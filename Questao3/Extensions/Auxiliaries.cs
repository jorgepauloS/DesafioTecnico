using Questao3.Models;

namespace Questao3
{
    public static class Auxiliaries
    {
        public static void RemoveFaturamentoZerado(ref List<Faturamento> listaFaturamento)
        {
            listaFaturamento.RemoveAll(e => e.Valor == 0);
        }

        public static bool TemZerado(List<Faturamento> listaFaturamento)
        {
            return listaFaturamento.Exists(e => e.Valor == 0);
        }

        public static Faturamento? Minimo(List<Faturamento> listaFaturamento)
        {
            return listaFaturamento.MinBy(e => e.Valor);
        }

        public static Faturamento? Maximo(List<Faturamento> listaFaturamento)
        {
            return listaFaturamento.MaxBy(e => e.Valor);
        }

        public static double Media(List<Faturamento> listaFaturamento)
        {
            return (listaFaturamento.Sum(e => e.Valor) / listaFaturamento.Count);
        }

        public static int DiasFaturamentoMaiorQueMedia(List<Faturamento> listaFaturamento)
        {
            return listaFaturamento.Where(e => e.Valor > Media(listaFaturamento)).Count();
        }
    }
}

