using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon
{
    internal class _195886
    {
        public static List<decimal> arr = new List<decimal>();
        static void ans(string[] args)
        {
            var n = Convert.ToDecimal(Console.ReadLine());
            List<decimal> rslt = new List<decimal>();
            for (decimal i = 1; i <= n; i++)
            {
                arr = new List<decimal>();
                permute(i.ToString(), 0, i.ToString().Length - 1);
                rslt.Add(GCD(arr.ToArray()));
            }
            Console.WriteLine(rslt.Sum());
            Console.ReadLine();
        }
        static decimal GCD(decimal[] numbers)
        {
            return numbers.Aggregate(GCD);
        }

        static decimal GCD(decimal a, decimal b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }
        static int fac(int a)
        {
            if (a == 0) return 0;
            if (a == 1) return 1;
            return a * fac(a - 1);
        }
        private static void permute(String str, int l, int r)
        {
            if (l == r)
                arr.Add(Convert.ToDecimal(str));
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = swap(str, l, i);
                    permute(str, l + 1, r);
                    str = swap(str, l, i);
                }
            }
        }

        public static String swap(String a,
                                  int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}
