using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func_Delegate_test_3
{
    internal class Program
    {
        //public delegate int SquareDelegate(int x);

        static Func<int, int> func = SquareMethod;

        static int SquareMethod(int x) => x * x;



        static void Main(string[] args)
        {
            //SquareDelegate obj = new SquareDelegate(SquareMethod);
            //int result = obj(10);
            //Console.WriteLine(result);



            int result2 = func(15);
            Console.WriteLine(result2);

        }
    }
}
