
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            //PointValueType();
            //  ReferenceType();
            //  ConvertShort();
            // FloatingPoint();
            //Real_Number_Rounding_Errors();
            StringInterpolation();
            Console.ReadLine();
        }

        private static void StringInterpolation()
        {
            int x = 4;
            Console.WriteLine($"A \asquare has {x} sides"); // Prints: A square has 4 sides
            string s = $"255 in hex is {byte.MaxValue:X2}"; // X2 = 2-digit Hexadecimal
            Console.WriteLine(s);

            int x1 = 2;
            string s1 = $@"this spans {
            x1} lines";
            Console.WriteLine(s1);
        }

        private static void Real_Number_Rounding_Errors()
        {
            float tenth = 0.1f; // Not quite 0.1
            float one = 1f;
            Console.WriteLine(one - tenth * 10f); // -1.490116E-08

            decimal m = 1M / 6M; // 0.1666666666666666666666666667M
            double d = 1.0 / 6.0; // 0.16666666666666666
            Console.WriteLine(m);
            Console.WriteLine(d);
            decimal notQuiteWholeM = m + m + m + m + m + m; // 1.0000000000000000000000000002M
            double notQuiteWholeD = d + d + d + d + d + d; // 0.99999999999999989
            Console.WriteLine(notQuiteWholeM);
            Console.WriteLine(notQuiteWholeD);
            Console.WriteLine(notQuiteWholeM == 1M); // False
            Console.WriteLine(notQuiteWholeD < 1.0); // True
        }

        private static void FloatingPoint(){
            Console.WriteLine(1.0 / 0.0); // Infinity
            Console.WriteLine(-1.0 / 0.0); // -Infinity
            Console.WriteLine(1.0 / -0.0); // -Infinity
            Console.WriteLine(-1.0 / -0.0); // Infinity
            Console.WriteLine(0.0 / 0.0); // NaN
            Console.WriteLine((1.0 / 0.0) - (1.0 / 0.0)); // NaN
            Console.WriteLine(0.0 / 0.0 == double.NaN); // False
            Console.WriteLine(double.IsNaN(0.0 / 0.0)); // True
        }

        private static void ConvertShort()
        {
            short x = 1, y = 1;
           // short z = x + y; //Compiler Error
            short z = (short)(x + y);//OK
            Console.WriteLine(z);

        }

        static void ReferenceType()
        {
            ReferenceTypes.Point p1 = new ReferenceTypes.Point();
            p1.X = 7;
            ReferenceTypes.Point p2 = p1; // Copies p1 reference
            Console.WriteLine(p1.X); // 7
            Console.WriteLine(p2.X); // 7
            p1.X = 9; // Change p1.X
            Console.WriteLine(p1.X); // 9
            Console.WriteLine(p2.X); // 9
            //string.Empty
        }

        public static void PointValueType()
        {
            ValueTypes.Point p1 = new ValueTypes.Point();
            p1.X = 7;
            ValueTypes.Point p2 = p1; // Assignment causes copy
            Console.WriteLine(p1.X); // 7
            Console.WriteLine(p2.X); // 7
            p1.X = 9; // Change p1.X
            Console.WriteLine(p1.X); // 9
            Console.WriteLine(p2.X); // 7
        }
    }
}
