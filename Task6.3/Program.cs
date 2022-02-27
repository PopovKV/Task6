using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int k = 1;
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Equals('}')==true)
                {
                    a = i;                    
                    while (a>0)
                    {
                        if (s[a].Equals('{')==true)
                        {
                            s = s.Remove(a, k);
                            i = i - k;
                            break;
                        }
                        k++;
                        a--;
                    }
                    a = 0;
                    k = 1;
                }
            }
            Console.WriteLine("{0}",s);
            Console.ReadKey();
        }
    }
}
