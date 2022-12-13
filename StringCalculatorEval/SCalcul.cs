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

            return part.Select(int.Parse).Sum();
            //return OverflowException;
        }
    }
}
