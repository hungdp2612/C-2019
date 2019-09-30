using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Floor(4));
        }
        //output: 7.6 = 7; 7.4 = 7
        static int Floor(float x)
        {
            return (int)x;
        }
    }
}
