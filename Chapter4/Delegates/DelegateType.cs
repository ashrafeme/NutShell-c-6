using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4.Delegates {
    public delegate int Transform(int v);
    public class DelegateType {


        static int Square(int x) => x * x;


        public void data() {
            Transform t = Square;
            Console.WriteLine(t.Invoke(100));
            var answer = t(3);
            Console.WriteLine(answer);

            int[] values = { 1, 2, 3 };
            Util.Transform(values, t);
            foreach (var item in values) {
                Console.WriteLine(item);
            }
        }

    }

    class Util {
        public static void Transform(int[] values, Transform t) {
            for (int i = 0; i < values.Length; i++) {
                values[i] = t(values[i]);
            }
        }
    }
}
