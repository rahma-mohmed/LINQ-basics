using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQD11
{
    public static class ExtentionFun
    {
        public static IEnumerable<Employee> Filter(this IEnumerable<Employee> employees, Func<Employee, bool> test)
        {
            foreach (Employee e in employees)
            {
                if (test(e))
                {
                    yield return e;
                }
            }
        }

        public static void Print<T>(this IEnumerable<T> source, string title)
        {
            if (source == null)
                return;
            Console.WriteLine();
            Console.WriteLine("****************************************");
            Console.WriteLine($"│   {title.PadRight(56, ' ')}│");
            Console.WriteLine("****************************************");

            Console.WriteLine();
            foreach (var item in source)
            {
                if (typeof(T).IsValueType)
                    Console.Write($" {item} ");
                else
                    Console.WriteLine(item);
            }
        }
    }
}
