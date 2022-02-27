using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();            
            string s1 = "";
            s = s.ToLower();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Equals(' ') == true)
                {
                    s = s.Remove(i, 1);                                       
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Equals(' ') == false)
                {
                    s1 += s[s.Length-i-1];
                }
            }
           if (s1.Equals(s) == true)
            {
                Console.WriteLine("Введенная строка является палиндромом");
            }
            else
            {
                Console.WriteLine("Введенная строка не является палиндромом");
            }
            Console.ReadKey();
        }
    }
}
