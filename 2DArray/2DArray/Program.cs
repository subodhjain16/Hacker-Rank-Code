using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            //int[,] arr = new int[,] { { -1, -1, 0, -9, -2, -2}, {-2, -1, -6, -8, -2, -5}, {-1 ,-1, -1, -2, -3, -4},{-1, -9, 2, -4, -4, -5}, {-7, -3 ,-3 ,-2, -9, -9}, {-1 ,-3, -1, -2, -4, -5} };
            int[,] arr = new int[,] { { 0, -4, -6, -0, -7, -6 }, { -1, -2, -6, -8, -3, -1 }, { -8, -4, -2, -8, -8, -6 }, { -3, -1, -2, -5, -7, -4 }, { -3, -5, -3, -6, -6, -6 }, { -3, -6, 0, -8, -6, -7 } };
            //for (int arr_i = 0; arr_i < 6; arr_i++)
            //{
            //    string[] arr_temp = Console.ReadLine().Split(' ');
            //    arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            //}
            // Number of possible combination of k x k sub arrays in n x n array are 
            // n-k+1 x n-k+1
            //i.e. for 6 x 6 array, the number of 3 x 3 arrays would be 
            // 6-3+1 x 6-3+1 i.e. 4x4 = 16
            int sum = 0; int n = 6; int k = 3;
            int max = 0;
            int count = 0;
            bool flag = false;
            for (int l = 0; l < n - k + 1; l++)
            {
                for (int i = 0; i < n - k + 1; i++)//outer loop
                {
                    Console.WriteLine("Array no - " + count.ToString());
                    Console.WriteLine("-----Incrementing i -----");
                    Console.WriteLine("value of i is " + i.ToString());
                    int count1 = 0;
                    for (int j = i; j < k + i; j++)
                    {
                        Console.WriteLine("-----Incrementing j -----");
                        Console.WriteLine("value of j is " + j.ToString());
                        for (int p = l; p < k + l; p++)
                        {
                            Console.WriteLine("arr [" + j.ToString() + "] [" + p.ToString() + "]" + " " + "value is " + arr[j, p]);
                            //Console.WriteLine("value of count 1 is  " + count1.ToString());
                            if (count1 != 3 && count1 != 5) // sum only for hr glass
                            {
                                //Console.WriteLine("value of count 1 is  " + count1.ToString());
                                //Console.WriteLine("adding value to sum " + arr[j, p].ToString());
                                sum = sum + arr[j, p];
                            }
                            count1++;
                        }
                        
                    }
                    //count1 = 0;
                    
                    count++;
                    Console.WriteLine("sum of this array is - " + sum.ToString());
                    Console.WriteLine("------------------------------------------");
                    if (max == 0 && flag == false)
                    {
                        max = sum;
                        flag = true;
                    }
                    else if (sum > max)
                    {
                        max = sum;
                        Console.WriteLine("max is - " + max.ToString());
                    }
                    
                    sum = 0;
                    count1 = 0;
                }
            }
            Console.WriteLine(max.ToString());
            Console.WriteLine(count.ToString());
        }
    }
}
