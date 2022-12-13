using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace StringCalculatorEval
{
    public class SCalcul
    {
        public static object Add(string data)
        {
            var part = ",";
            var StringElements = data.Replace(Environment.NewLine, string.Empty).Split(part);
            return String.Concat(StringElements);

        }
    }
}
