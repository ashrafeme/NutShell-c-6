using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JoinandSleep {
    class Program {
        static void Main(string[] args) {
            Thread th = new Thread(Go);
            th.Start();
            th.Join();
            Console.ReadLine();
        }

        private static void Go() {
            for (int i = 0; i < 1000; i++)
                Console.Write("y");
        }
    }
}
