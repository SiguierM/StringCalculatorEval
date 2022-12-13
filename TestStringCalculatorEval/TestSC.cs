using StringCalculatorEval;

namespace TestStringCalculatorEval
{
    public class TestSC
    {
        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 7)]
        [InlineData(3, 9)]
        [InlineData(int.MaxValue, 0)]

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
        [InlineData(2, 10, 58)]

        public void TestAddXNumbers(int x, int y, int z)
        {
            // ETANT DONNE x nombres (x, y, z, ...)
            var data = $"{x}, {y}, {z}"; 

            // QUAND on appelle Add 
            var result = SCalcul.Add(data); 

            // ALORS on obtient la somme de x nombres 
            Assert.Equal(x + y + z, result);
        }

        [Fact]

        public void TestSauts()
        {
            // ETANT DONNE une chaine x,y avec un saut de ligne entre les deux nombres
            var data = "1, 2" + Environment.NewLine + "0";

            // QUAND on appelle Add
            var result = SCalcul.Add(data); 

            // ALORS on obtient quand même la somme de x et y 
            Assert.Equal(12, result);
        }
        
    }
}