using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandNumGenerator
{
    internal class Thread2
    {
        public int start { get; set; } = 2;
        public int end { get; set; } = int.MaxValue;
        public thread2(int start, int end)
        {
            this.start = start;
            this.end = end;
            for(int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    Container.simplelist.Add(i);
                }
            }
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
