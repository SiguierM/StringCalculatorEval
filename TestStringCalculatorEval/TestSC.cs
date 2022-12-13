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
            Assert.Equal(x.ToString() + y.ToString(), result);
        }

        [Theory]
        [InlineData(0, 1, 2)]
        [InlineData(2, 10, 58, 21)]
        [InlineData(2, 54, 26, 84, 29)]

        public void TestAddXNumbers(params int[]x)
        {
            // ETANT DONNE x nombres (x, y, z, ...)
            var data = string.Join(',', x); 

            // QUAND on appelle Add 
            var result = SCalcul.Add(data); 

            // ALORS on obtient la somme de x nombres 
            Assert.Equal(String.Concat(x), result);
        }

        [Fact]

        public void TestSauts()
        {
            // ETANT DONNE une chaine x,y avec un saut de ligne entre les deux nombres
            var data = "1,2" + Environment.NewLine + "0";

            // QUAND on appelle Add
            var result = SCalcul.Add(data); 

            // ALORS on obtient quand même la somme de x et y 
            Assert.Equal("120", result);
        }

        [Fact]

        public void TestIgnorer()
        {
            // ETANT DONNE une chaîne de nombres où un est supérieur à 1000
            const string data = "1, 1009, 1000"; 

            // QUAND on appelle Add
            var result = SCalcul.Add(data); 

            // ALORS le nombre est ignoré 
            var dataIgnore = "1, 1000";
            var resultIgnore = SCalcul.Add(dataIgnore); 

            Assert.Equal(resultIgnore, result);
        }
    }
}