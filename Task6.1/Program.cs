using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            string s1 = "";             
            int c = 0;
            foreach (string a in s)
            {
                if (a.Length > c)
                {
                    c = a.Length;
                    s1 = a;
                }                
            }
            Console.WriteLine("Самое длинное слово в строке - {0}",s1);
            Console.ReadKey();
        }
    }
}
