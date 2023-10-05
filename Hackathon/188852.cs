using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon
{
    internal class _188852
    {
        static void ans(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] k = new int[n];
            for (int i = 0; i < n; i++)
            {
                int shop = int.Parse(Console.ReadLine());
                k[i] = 0;
                for (int j = 0; j < shop; j++)
                {
                    switch (Console.ReadLine())
                    {
                        case "buy_one copy_paste":
                        case "copy_paste buy_one":
                            if (k[i] > 1)
                                k[i] *= 2;
                            else k[i]++;
                            break;
                        case "buy_one buy_one":
                            k[i]++;
                            break;
                        case "copy_paste copy_paste":
                            k[i] *= 2;
                            break;
                        default:
                            break;
                    }
                }
            }
            foreach (int i in k) Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
