using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_async_await.misc
{
    public static class Factor
    {
        public static void process(int[] sample)
        {
            var size = sample.Length;
            pthFactor(10, 3);

        }

        private static long getMinimizedBy(long number, long divisor)
        {
            while (number % divisor == 0)
            {
                number = number / divisor;
            }
            return number;
        }

        public static long pthFactor(long n, long p)
        {
            int factor = 1, divisor = 2;
            int factorIndex = 1;
            long input = n;
            long range = (long)Math.Sqrt(input);

            while (n % 2 == 0)
            {
                n = n / 2;
                factorIndex++;
                if (factorIndex == p) return factor * 2;
                factor = factor * 2;

            }

            while (n % 3 == 0)
            {
                n = n / 3;
                factorIndex++;
                if (factorIndex == p) return factor * 3;
                factor = factor * 3;

            }


            for (int i = 5; i <= input / 2 && factor * i <=input; i += 6)
            {
                int num = i;
                //factor = i;


                while (n % num == 0)
                {
                    n = n / num;
                    factorIndex++;
                    if (factorIndex == p) return factor * num;
                    factor *= num;
                }

            }


            return 0; //OrderBy(key => key.Key)

        }
    }

}
