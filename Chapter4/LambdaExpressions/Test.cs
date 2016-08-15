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


        public static void Capturing_Outer_Variables() {
            int factor = 2;
            Func<int, int> multiplier = x => x * factor;
            factor = 10;
            Console.WriteLine(multiplier(3));

            // int seed = 0;

            Func<int> natural = Natural(); //() =>seed++;

            Console.WriteLine(natural());
            Console.WriteLine(natural());
            //  Console.WriteLine(seed);

        }

        static Func<int> Natural() {
            // int seed = 0;
            return () => { int seed = 0; return seed++; };
        }

       public static void Capturing_Iteration_Variables() {

            Action[] actions = new Action[3];
            for (int i = 0; i < 3; i++) {
                int innerloop = i;
                actions[i] = () => Console.Write(innerloop);
            }
            foreach (Action a in actions)
                a(); // 333
        }
    }
    
}
