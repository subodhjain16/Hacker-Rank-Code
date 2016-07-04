using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int strcount = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = new string[strcount];
            //string[] arr_temp = Console.ReadLine();
            for (int readstr = 0; readstr < strcount; readstr++)
            {
                arr_temp[readstr] = Console.ReadLine();
            }
            int [] arr1 = new int[strcount];
            int i = 0;
            int deletecount = 0;
            for (int j = 0; j < strcount; j++)
            {
                str = arr_temp[j];
                //Console.WriteLine(str);
                while (i < str.Length - 1)
                {
                    if (str[i] == str[i + 1])
                    {
                        deletecount++;
                    }
                    i++;
                }
                //Console.WriteLine(deletecount.ToString());
                arr1[j] = deletecount;
                deletecount = 0;
                i = 0;
            }
            for (int k = 0; k < strcount; k++)
            {
                Console.WriteLine(arr1[k].ToString());
            }
        }
    }
}
