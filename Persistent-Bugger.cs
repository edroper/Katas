using System;
using System.Linq;

public class Persist 
{
    public static int Persistence(long n)
        {
            if (n <= 9) return 0;

            var opCount = 0;
            var result = n.ToString().Select(t => int.Parse(t.ToString())).ToArray();

            while (result.Length != 1)
            {
                int prod = result.Aggregate(1, (a, b) => a * b);
                result = prod.ToString().Select(t => int.Parse(t.ToString())).ToArray();
                opCount++;
            }
            return opCount;
        }

}
