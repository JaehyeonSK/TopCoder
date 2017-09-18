using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Encryption
{
    class Cryptography
    {
        public long encrypt(int[] numbers)
        {
            long answer = 1;

            Array.Sort(numbers);
            numbers[0] += 1;

            foreach (int n in numbers)
            {
                answer *= n;
            }

            return answer;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
