using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace githubtest
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1 ; i<=9 ; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write(j.ToString() + "*" + i.ToString()+ "=" + (i*j).ToString() + " ");
                }
                Console.WriteLine("");
            }
            Console.Read();
        }
    }
}
