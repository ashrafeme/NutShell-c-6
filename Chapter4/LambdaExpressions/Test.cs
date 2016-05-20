using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4.LambdaExpressions {
    delegate int Transformer(int i);

    class Test {
       public static void MainTest() {
            Transformer square = x => x * x;
            Console.WriteLine(square(3));    // 9
        }
    }
}
