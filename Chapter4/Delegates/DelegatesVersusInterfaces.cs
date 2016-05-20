using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4.Delegates {
    class DelegatesVersusInterfaces {
        public static void TransformAll(int[] values, ITransformer t) {
            for (int i = 0; i < values.Length; i++)
                values[i] = t.Transform(values[i]);
        }

        public static void TransformAllTest() {

            int[] values = { 1, 2, 3 };
            TransformAll(values, new Squarer());
            foreach (int i in values)
                Console.WriteLine(i);
        }
    }

    public class Squarer : ITransformer {
        public int Transform(int t) => t * t;
    }

    public interface ITransformer {
        int Transform(int t);
    }
}
