using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //MaxTest();

            //var pair = new Pair<int>(1, 2);
            //Console.WriteLine(pair);

            //var day = new Pair<DateTime>(
            //    DateTime.Today,
            //    DateTime.Today.AddDays(1)
            //);
            //Console.WriteLine(day);

            //var p2 = new Pair<int, string>(3, "three");
            //Console.WriteLine(p2);

            var p = new Pair<int>(1, 2);
            var tree = new Pair<Pair<int>, Pair<int>>(
                new Pair<int>(1, 2),
                new Pair<int>(1, 2));

            Console.WriteLine(tree);
            tree.Second.First = 3;
            Console.WriteLine(tree);

        }


















        private static void MaxTest()
        {
            var x = Utils.Max(3, 6);
            Console.WriteLine("6:" + x);

            var y = Utils.Max(-5, -2);
            Console.WriteLine("-2:" + y);

            var z = Utils.Max<double>(5, 2.6f);
            Console.WriteLine("5:" + z);

            Console.WriteLine(Utils.Max("Adam", "Bertil"));
            Console.WriteLine(Utils.Max(true, false));
        }
    }
}