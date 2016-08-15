
using Chapter4.Delegates;
using Chapter4.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4 {
    class Program {
        static void Main(string[] args) {
            /*
            DelegateType ote = new DelegateType();
            ote.data();

            MulticastDelegates omd = new MulticastDelegates();
            omd.TestHardWorker();

            GenericDelegateTypes ogdt = new GenericDelegateTypes();
            ogdt.TestGDT();
           
            DelegatesVersusInterfaces.TransformAllTest();
           


            ParameterCompatibility.UseStringAction();
            */

            //   StandardEventPattern.PriceChangedTest();
            // LambdaExpressions.Test.MainTest();
            //LambdaExpressions.Test.Capturing_Outer_Variables();
            LambdaExpressions.Test.Capturing_Iteration_Variables();

            System.Console.ReadKey();
        }
    }
}
