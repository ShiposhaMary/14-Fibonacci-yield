using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fibonacci_yield
{
    public class Sequences
    {
        public static IEnumerable<int> Fibonacci
        {
            get
            {
                var a = 1;
                var b = 1;
                yield return 1;
                yield return 1;
                while (true)
                {
                    var c = a + b;
                    a = b;
                    b = c;
                    yield return c;
                }
            }
        }
        //И вот так.
        public static IEnumerable<int> Exponential(int multiplier)
        {
            var a = 1;

            while (true)
            {
                yield return a;
                a *= multiplier;
            }
        }

        //Если свойство или метод возвращает IEnumerable<T>, то в нем можно писать yield return
    }
    class Program
    {
        static void Main()
        {
            foreach(var e in Sequences.Fibonacci)
            {
                Console.WriteLine(e);
                Thread.Sleep(100);
                if (Console.KeyAvailable) break;
            }

        }
    }
}
