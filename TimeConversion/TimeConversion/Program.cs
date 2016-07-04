using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string time = Console.ReadLine();
            if (time.Contains("AM"))
            {
                string str1 = time.Substring(0, 2);
                //int hr = Convert.ToInt32(str1);
                if (str1 == "12")
                {
                    str1 = "00";
                }
                time = str1 + time.Substring(2, time.Length-2);
                Console.Write(time);
            }
            else if (time.Contains("PM"))
            {
                string str1 = time.Substring(0, 2);
                if (str1 != "12")
                {
                    int hr = Convert.ToInt32(str1);
                    hr = hr + 12;
                    str1 = hr.ToString();
                }
                time = str1 + time.Substring(2, time.Length - 2);
                Console.Write(time);
            }

        }
    }
}
