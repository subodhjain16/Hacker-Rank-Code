using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            //string str = "We promptly judged antique ivory buckles for the prize";
            //Console.WriteLine(str1);
            //if (IsPanagram (str1))
            //    Console.Write("pangram");
            //else
            //    Console.Write("not pangram");

        //}
        //static bool IsPanagram(string str)
       // {
            char [] arr = new char [26];
            int count = 0;
            int ascii_val = 0;
            //if (str.Length == 0)
            //    return false;
            str = str.Replace(" ", "");
            str = str.ToLower();
            //Console.Write(arr[0]);
            for (int i1 = 0; i1 < str.Length; i1++)
            {
                ascii_val = (int)str[i1];
                if (arr[ascii_val-97] == '\0')
                {
                    arr[ascii_val - 97] = str[i1];
                    count++;
                }

            }
            if (count == 26)
                Console.Write("pangram");
            else
                Console.Write("not pangram");
        }
    }
}
