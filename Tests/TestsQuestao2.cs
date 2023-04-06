namespace Tests
{
    public class TestsQuestao2
    {
        [Theory]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(7)]
        public void NaoDeveFazerParte(int pivot)
        {
            Assert.False(Questao2.Fibonnaci.PivotFibonnaciSequence(pivot));
        }


        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(13)]
        public void DeveFazerParte(int pivot)
        {
            Assert.True(Questao2.Fibonnaci.PivotFibonnaciSequence(pivot));
        }
    }
}