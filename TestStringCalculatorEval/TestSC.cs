using StringCalculatorEval;

namespace TestStringCalculatorEval
{
    public class TestSC
    {
        [Theory]
        [InlineData(1, 2)]

        public void TestAdd(int x, int y)
        {
            // ETANT DONNE 1 + 2
            var data = $"{x},{y}"; 

            // QUAND on appelle Add
            var result = SCalcul.Add(data); 

            // ALORS on obtient 3
            Assert.Equal(x + y, result);
        }
    }
}