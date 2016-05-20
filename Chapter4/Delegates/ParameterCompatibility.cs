using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4.Delegates {
    class ParameterCompatibility {
        delegate void StringAction(string s);
        delegate void ManagerAction(Manager m);
        // contravariance
        public static void UseStringAction() {
            StringAction sa = new StringAction(ActionObject);
            ManagerAction ma = new ManagerAction(ActionEmployee);
            sa("hello");
            ma(new Manager {
                Name = "Ashraf"
            });

            ActionManager(new Manager {
                Name = "Ashraf"
            });
        }

        static void ActionManager(Employee m) => Console.WriteLine(m.Name);

        private static void ActionEmployee(Employee m) => Console.WriteLine(m.Name);



        private static void ActionObject(object s) => Console.WriteLine(s);
    }

    class Employee {
        public string Name { get; set; }
    }

    class Manager : Employee {
        public string Salary { get; set; }
    }


}
