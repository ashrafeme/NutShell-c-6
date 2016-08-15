using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo {
    class Program {
        static void Main(string[] args) {

            string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
            IEnumerable<string> query = names
            .Where(n => {
                Console.WriteLine(n + "(" + n.Contains("a") + ")");
                Console.WriteLine("+====================+============+========");
                return n.Contains("a");
                })
            .OrderBy(n => {
                Console.WriteLine(n + "(" + n.Length + ")");
                Console.WriteLine("+====================+============+========");
                return n.Length;
            })
            .Select(n => {
                Console.WriteLine(n + "(" + n.ToUpper() + ")");
                Console.WriteLine("+====================+============+========");
                return n.ToUpper();
            });


            Console.WriteLine("before Start get query");
            foreach (string name in query) {
                Console.WriteLine("Start get query");
                Console.WriteLine(name);
            }
        }
    }
}
