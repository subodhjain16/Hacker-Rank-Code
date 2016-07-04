using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertionsort
{
    class Program
    {
        static void Main(string[] args)
        {
            int _ar_size;
            _ar_size = Convert.ToInt32(Console.ReadLine());
            int[] _ar = new int[_ar_size];
            String elements = Console.ReadLine();
            String[] split_elements = elements.Split(' ');
            for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
            {
                _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
            }
            //print(_ar, _ar_size);
            insertionSort(_ar, _ar_size);
        }
        static void insertionSort(int[] ar, int size)
        {
            int lastelement = ar[size - 1];
            for (int i = size-1; i >= 0; i--)
            {
                int value = ar[i];
                if (i == 0)
                {
                    if (ar[i] > lastelement)
                    {
                        ar[i] = lastelement;
                        print(ar, size);
                        break;
                    }
                }
                else if (ar[i - 1] > lastelement)
                {
                    ar[i] = ar[i - 1];
                }
                else
                {
                    ar[i] = lastelement;
                    print(ar, size);
                    break;
                }
                print(ar, size);
            }

        }
        static void print(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i].ToString());
                if (i != n - 1)
                    Console.Write(" ");
                else
                    Console.Write("\n");
            }
        }
    }
}
