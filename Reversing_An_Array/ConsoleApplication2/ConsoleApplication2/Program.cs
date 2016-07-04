using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int i = 0; int j = n - 1; int tmp;
            while (i < j) //run the loop while i is less then j
            {
                //swap the elements
                tmp = arr[i];
                arr[i] = arr[j];
                arr[j] = tmp;
                //increament i to point to next element, decrement j to point to previous element
                i++;
                j--;
            }
            //print the array 
            i = 0;
            while (i < n)
            {
                Console.Write(arr[i].ToString());
                if (i != n-1) //Append the space only except the last element
                Console.Write(" ");
                i++;
            }
        }
    }
}
