using StringCalculatorEval;

namespace TestStringCalculatorEval
{
    public class TestSC
    {
        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 7)]
        [InlineData(3, 9)]
       // [InlineData(int.MaxValue, 9)]

        public void TestAdd(int x, int y)
        {
            // ETANT DONNE x , y
            var data = $"{x},{y}"; 

            // QUAND on appelle Add
            var result = SCalcul.Add(data); 

            // ALORS on obtient x+y
            Assert.Equal(x + y, result);
        }

        [Theory]
        [InlineData(0, 1, 2)]

        public void TestAddXNumbers(int x, int y, int z)
        {
            // ETANT DONNE x nombres (x, y, z, ...)
            var data = $"{x}, {y}, {z}"; 

            // QUAND on appelle Add 
            var result = SCalcul.Add(data); 

            // ALORS on obtient la somme de x nombres 
            Assert.Equal(x + y + z, result);
        }
    }
}