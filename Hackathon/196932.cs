using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon
{
    internal class _196932
    {
        static void ans()
        {
            string myget = Console.ReadLine();

            int n = int.Parse(myget.Split()[0]);
            int k = int.Parse(myget.Split()[1]);
            int[] chob = new int[n];

            myget = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                chob[i] = int.Parse(myget.Split()[i]);
            }

            int numFrames = NumFrames(n, k, chob);

            Console.WriteLine(numFrames);
            Console.ReadLine();
        }
        static int NumFrames(int n, int k, int[] lengths)
        {
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    for (int m = j + 1; m < n; m++)
                    {
                        int[] combo = { lengths[i], lengths[j], lengths[m] };
                        if (combo.Count() == k)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
