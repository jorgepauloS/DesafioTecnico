namespace Tests
{
    public class TestsQuestao5
    {
        [Theory]
        [InlineData("Vamos testar")]
        [InlineData("Eu quero saber se vai dar certo")]
        [InlineData("Vamos l�")]
        public void InversaoDeString(string pivot)
        {
            Assert.Equal(string.Join("", pivot.Reverse()), Questao5.StringInverter.Inversao(pivot));
        }
    }
}