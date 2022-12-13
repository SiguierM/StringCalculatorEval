using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorEval
{
    public class SCalcul
    {
        public static int Add(string data)
        {
            var part = data.Split(',');

            var firstNumber = int.Parse(part.First());
            var secondNumber = int.Parse(part.Last());
            return firstNumber + secondNumber; 
        }
    }
}
