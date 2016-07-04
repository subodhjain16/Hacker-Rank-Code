using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] arr = new int[,] { { 11, 2, 4 }, { 4, 5, 6 }, { 10, 8, -12 } };
            //int n = 3;

            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }
            int sum1 = 0; int sum2 = 0;
            //Calculate sum of first diagonal 
            for ( int i = 0; i < n; i++)
            {
                sum1 = sum1 + a[i][i];
            }
            //Console.WriteLine(sum1.ToString());
            //Calculate sum of 2nd diagonal 
            for (int i = 0, j = n-1; i < n; i++, j--)
            {
                sum2 = sum2 + a[i][j];
            }
            //Console.WriteLine(sum2.ToString());
            Console.WriteLine(Math.Abs(sum1 - sum2).ToString());

        }
    }
}
