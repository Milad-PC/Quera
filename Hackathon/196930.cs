using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon
{
    internal class _196930
    {
        public void ans()
        {
            int n = int.Parse(Console.ReadLine());
            string output = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string x1 = Console.ReadLine().ToLower();
                string x2 = x1.Split(' ')[1];
                x1 = x1.Split(' ')[0];

                if (x1.Length != x2.Length) { output += "NO\n"; continue; }
                if (x1 == x2) { output += "YES\n"; continue; }

                if (check(x1, x2)) { output += "YES\n"; }
                else if (check(x1, new string(x2.Reverse().ToArray()))) { output += "YES\n"; }
                else { output += "NO\n"; }
            }
            Console.WriteLine(output);
        }
        public static bool check(string x1, string x2)
        {
            if (x1 == x2) return true;
            else
            {
                for (int i = 0; i < x1.Length; i++)
                {
                    x1 = ShiftStringRight(x1);
                    if (x1 == x2) return true;
                }
                for (int i = 0; i < x1.Length; i++)
                {
                    x1 = ShiftStringLeft(x1);
                    if (x1 == x2) return true;
                }
                return false;
            }
        }
        public static string ShiftStringLeft(string t)
        {
            return t.Substring(1, t.Length - 1) + t.Substring(0, 1);
        }
        public static string ShiftStringRight(string t)
        {
            return t.Substring(t.Length - 1, 1) + t.Substring(0, t.Length - 1);
        }
    }
}
