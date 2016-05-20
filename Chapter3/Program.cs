using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indexers.Sentence os = new Indexers.Sentence();
            var s = new Indexers.Sentence();
            Console.WriteLine(s[3]); // fox
            s[3] = "kangaroo";
            Console.WriteLine(s[3]); // kangaroo
        }
    }
}
