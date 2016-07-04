using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int k = 0; k < n; k++)
            {
                int count = 0;
                for (int i = n - (k +1) ; i > 0; i--)
                {
                    Console.Write(" ");
                    count++;
                }
                for (int j = 0; j < n-count; j++)
                {
                    Console.Write("#");
                }
                if (k < n)
                Console.Write("\n");
            }

        }
    }
}
