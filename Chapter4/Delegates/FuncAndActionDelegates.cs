using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4.Delegates {
    class FuncAndActionDelegates {
        void TransformArray<T>(T[] values, Func<T,T> t) {

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
