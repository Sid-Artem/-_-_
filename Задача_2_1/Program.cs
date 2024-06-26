using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2_1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string str = Console.ReadLine();
            str = str.Replace(" ", "");
            str = str.ToLower();
            string str2 = "";
            foreach (char c in str)
            {

                str2 = c + str2;

            }
            str2 = str2.Replace(" ", "");
            str2 = str2.ToLower();
            if (str2 == str) Console.WriteLine("Строка является палиндромом");
            else
            Console.WriteLine("Строка не является палиндромом");
            Console.ReadLine();
        }
    }
}