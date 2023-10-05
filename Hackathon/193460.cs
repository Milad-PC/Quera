using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon
{
    internal class _193460
    {
        static void ans()
        {
            int Cm, Gm, Cs, Gs, rate;
            string input = Console.ReadLine();
            Cm = int.Parse(input.Split()[0]);
            Gm = int.Parse(input.Split()[1]);
            input = Console.ReadLine();
            Cs = int.Parse(input.Split()[0]);
            Gs = int.Parse(input.Split()[1]);
            input = Console.ReadLine();
            rate = int.Parse(input);

            if ((Cm + (Gm * rate)) >= (Cs + (Gs * rate))) Console.WriteLine("Yes");
            else Console.WriteLine("No");

            Console.ReadLine();
        }
    }
}
