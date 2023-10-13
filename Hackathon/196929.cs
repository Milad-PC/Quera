using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon
{
    internal class _196929
    {
        public void ans()
        {
            int n = int.Parse(Console.ReadLine());
            int o = 1;
            for (int i = 0; i < n; i++)
            {
                string x = Console.ReadLine();
                int o1 = int.Parse(x.Split(' ')[0]);
                int o2 = int.Parse(x.Split(' ')[1]);
                if (o1 == o2) { throw new Exception(); }
                if (o1 != o && o2 != o) { continue; }
                if (o1 == o)
                {
                    o = o2;
                }
                else
                {
                    o = o1;
                }
            }
            Console.WriteLine(o);
        }
    }
}
