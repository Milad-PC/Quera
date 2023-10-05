using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon
{
    internal class _170058
    {
        static void Main1(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = new string[n];
            for (int i = 0; i < n; i++)
            {
                input[i] = Console.ReadLine().ToLower();
            }
            // All input Resived

            string[] output = new string[n];
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray();
            Array.Reverse(alpha);

            int x = 1;

            for (int i = 0; i < n; i++)
            {
                x = 1;
                for (int j = 0; j < alpha.Length; j++)
                {
                    while (input[i].IndexOf(alpha[j]) >= 0)
                    {
                        int index = input[i].IndexOf(alpha[j]);
                        input[i] = input[i].Remove(index, 1);
                        input[i] = input[i].Insert(index, $"{x} ");
                        x = x + 1;
                    }
                }
                output[i] = input[i];
            }

            foreach (string item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}
