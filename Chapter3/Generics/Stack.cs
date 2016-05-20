using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3.Generics {

    public class Animal { }
    public class Bear : Animal { }
    public class Camel : Animal { }
    public interface IPoppable<out T> { T Pop(); }

    public class Stack<T> : IPoppable<T> // A simple Stack implementation
    {
        int position;
        T[] data = new T[100];
        public void Push(T obj) => data[position++] = obj;
        public T Pop() => data[--position];
    }

    public class ZooCleaner {
        public static void Wash<T>(Stack<T> animals) where T : Animal { }
        public static void Wash(IPoppable<Animal> animals) { }
    }

    public class Client {

        public Client() {
            Stack<Bear> bears = new Stack<Bear>();
            ZooCleaner.Wash(bears);

            Bear[] bearss = new Bear[3];
            Animal[] animals = bearss;
            animals[0] = new Camel();

        }

        public void Master() {
            var bears = new Stack<Bear>();
            bears.Push(new Bear());
            IPoppable<Animal> animals = bears;
            Animal a = animals.Pop();
        }
    }
}
