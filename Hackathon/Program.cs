using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Hackathon
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            // End Of Inputs
            if (n < 2)
            {
                Console.WriteLine("100.0000");
                return;
            }
            // End Of Inputs Check
            double[] dgre = new double[n];
            int i = 0;

            for (i = 0; i < n; i++)
            {
                dgre[i] = Convert.ToDouble(s.Split()[i].ToString());
            }
            dgre = dgre.OrderBy(x => x).ToArray();
            double max = dgre[1] - dgre[0];
            for (i = 2; i < n; i++)
            {
                if (dgre[i] - dgre[i - 1] > max)
                    max = dgre[i] - dgre[i - 1];
            }
            Console.WriteLine((max*100/360).ToString().Replace('/','.'));
        }
    }
}
