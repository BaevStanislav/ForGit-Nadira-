using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForGit
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello Gitttt");

            int n = 5, i, j, num = 1, gap;
            gap = n - 1;
            for (j = 1; j <= n; j++)
            {
                num = j;
                for (i = 1; i <= gap; i++)
                    Console.Write("");
                gap--;
                for (i = 1; i <= j; i++)
                {
                    Console.Write(num);
                    num++;
                }
                num--;
                num--;
                for (i = 1; i < j; i++)
                {
                    Console.Write(num);
                    num--;
                }
                Console.WriteLine("");
            }
    }
}
