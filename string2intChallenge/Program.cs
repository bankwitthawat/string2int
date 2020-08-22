using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string2intChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please input your string: ");

            //string str2int = 
            string a = Console.ReadLine();
            string b = string.Empty;
            int val;

            for (int i = 0; i < a.Length; i++)
            {
                if (Char.IsDigit(a[i]))
                    b += a[i];
            }

            if (b.Length > 0)
            {
                val = int.Parse(b);
                Console.WriteLine("number is: " + val);
                Console.Read();
            }
            else
            {
                Console.WriteLine("error...");
                Console.Read();
            }


        }
    }
}
