using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_InterestingDigits
{
    public class InterestingDigits
    {
        public int[] digits(int bas)
        {
            List<int> numbers = new List<int>();

            for (int n = 2; n < bas; ++n)
            {
                bool pass = true;
                int t = n;

                while (t < 1000)
                {
                    int temp = t;
                    int rem = 0;

                    while (temp > 0)
                    {
                        rem += temp % bas;
                        temp /= bas;
                    }

                    if (rem % n != 0)
                    {
                        pass = false;
                        break;
                    }

                    t += n;
                }

                if (pass)
                    numbers.Add(n);
            }

            return numbers.ToArray();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var n = new InterestingDigits().digits(30);
            n.ToList().ForEach(Console.WriteLine);
        }
    }
}
