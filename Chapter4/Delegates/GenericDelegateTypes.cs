using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4.Delegates {
    delegate T TransformValue<T>(T t);
    class GenericDelegateTypes {

        void TransformArray<T>(T[] values, TransformValue<T> t) {

            for (int i = 0; i < values.Length; i++) {
                values[i] = t(values[i]);
            }
        }

        public void TestGDT() {
            int[] values = { 1, 2, 3 };
            TransformArray(values, Square);
            foreach (var item in values) {
                Console.WriteLine(item);
            }
        }

        int Square(int x) => x * x;

    }
}
