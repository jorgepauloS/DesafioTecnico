using Questao3.Models;

namespace Tests
{
    public class TestsQuestao3
    {
        private readonly List<Faturamento> faturamentos = new()
        {
            new Faturamento { Dia = 1, Valor = 1 },
            new Faturamento { Dia = 2, Valor = 2 },
            new Faturamento { Dia = 3, Valor = 3 }
        };


        [Fact]
        public void TemZerado()
        {
            Assert.False(Questao3.Auxiliaries.TemZerado(faturamentos));
        }

        [Fact]
        public void Minimo()
        {
            Assert.Equal(1, Questao3.Auxiliaries.Minimo(faturamentos).Valor);
        }

        [Fact]
        public void Maximo()
        {
            Assert.Equal(3, Questao3.Auxiliaries.Maximo(faturamentos).Valor);
        }

        [Fact]
        public void Media()
        {
            Assert.Equal(2, Questao3.Auxiliaries.Media(faturamentos));
        }

        [Fact]
        public void DiasFaturamentoMaiorQueMedia()
        {
            Assert.Equal(1, Questao3.Auxiliaries.DiasFaturamentoMaiorQueMedia(faturamentos));
        }
    }
}