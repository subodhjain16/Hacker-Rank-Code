using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindthElementFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32( Console.ReadLine());
            int index = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            for (int i = 0; i < index; i++)
            {
                if (arr[i] == num)
                {
                    Console.WriteLine(i.ToString());
                    break;
                }
            }
        }
    }
}
