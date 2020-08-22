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

            string input = Console.ReadLine();
            string result = new String(input.Where(Char.IsDigit).ToArray());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("your digi is " + int.Parse(result));
            Console.Read();




            //Console.WriteLine("please input your string: ");

            //string a = Console.ReadLine();
            //string b = string.Empty;
            //int val;

            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (Char.IsDigit(a[i]))
            //        b += a[i];
            //}

            //if (b.Length > 0)
            //{
            //    val = int.Parse(b);
            //    Console.WriteLine("number is: " + val);
            //    Console.Read();
            //}
            //else
            //{
            //    Console.WriteLine("error...");
            //    Console.Read();
            //}

        }
    }
}
