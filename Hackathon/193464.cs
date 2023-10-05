using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon
{
    internal class _193464
    {
        public void ans()
        {
            string input = Console.ReadLine();
            int loop = int.Parse(input.Split()[0]) * int.Parse(input.Split()[1]);
            int n = int.Parse(Console.ReadLine());
            double speed = 0d;
            int car = 0;

            input = Console.ReadLine();
            double x = Convert.ToDouble(Convert.ToDouble(input.Split()[0]) + (Convert.ToDouble(loop) / Convert.ToDouble(input.Split()[1])));
            car = 1;
            x = speed;


            for (int i = 2; i <= n; i++)
            {
                input = Console.ReadLine();
                x = Convert.ToDouble(Convert.ToDouble(input.Split()[0]) + (Convert.ToDouble(loop) / Convert.ToDouble(input.Split()[1])));
                if (x < speed)
                {
                    car = i;
                    x = speed;
                }
            }
            car++;
            Console.WriteLine(car);
            Console.ReadLine();
        }
    }
}
