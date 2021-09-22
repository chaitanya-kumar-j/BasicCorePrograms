using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class QuotientAndRemainder
    {
        public void Calculate( decimal a, decimal b)
        {
            int quotient = Decimal.ToInt32(a / b);
            int remainder = Decimal.ToInt32(((a / b) - quotient) * b);
            Console.WriteLine($"Quotient of {a}/{b} = {quotient}");
            Console.WriteLine($"Remainder of {a}/{b} = {remainder}");
        }
    }
}
