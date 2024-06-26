using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Я пошел {{гулять}} на работу";
            int first;
            int last;
            int length;
            first = str.IndexOf("{");
            last = str.IndexOf("}");
            length = last-first;
            str = str.Remove(first, length+2);
            Console.WriteLine(str);
            Console.ReadLine();
            
            
            
            
        }
    }
}
