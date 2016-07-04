using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contigious_Array
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = Convert.ToInt32(Console.ReadLine());
            string[] arrbig = new string[num*2];
            for (int i = 0; i < num * 2; i++)
            {
                arrbig[i] = Console.ReadLine();
            }

            for (int j = 0; j < num*2; j++)
            {
                int size = Convert.ToInt32(arrbig[j]);
                string[] arr_temp = arrbig[j+1].Split(' ');
                int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
                findsum(arr, size);
                j++;
            }
            
        }
        22222222222222222222222221x ki
    }
}
