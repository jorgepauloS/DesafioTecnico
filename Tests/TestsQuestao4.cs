using Questao4;

namespace Tests
{
    public class TestsQuestao4
    {
        private readonly Calculadora calc = new ();

        public TestsQuestao4()
        {
            calc.AddFaturamento("SP", 1);
            calc.AddFaturamento("RJ", 2);
            calc.AddFaturamento("MG", 3);
            calc.AddFaturamento("ES", 4);
            calc.AddFaturamento("Outros", 5);
        }

        [Fact]
        public void FaturamentoTotal()
        {
            Assert.Equal(15, calc.Total());
        }

        [Theory]
        [InlineData("SP", 6.66)]
        [InlineData("RJ", 13.33)]
        [InlineData("MG", 20)]
        public void FaturamentoPorEstado(string estado, double porcentagem)
        {
            Assert.Equal(porcentagem, calc.Porcentagem(estado), 0.01);
        }
    }
}