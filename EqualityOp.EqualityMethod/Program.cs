using System;

namespace EqualityOp.EqualityMethod
{
    class Program
    {
        static bool AreIntsEqualOp(int x, int y)
        {
            return x == y;
        }

        static bool AreIntsEqualMethod(int x, int y)
        {
            return x.Equals(y);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Method: "+ AreIntsEqualMethod(3,3));
            Console.WriteLine("Operator: " + AreIntsEqualOp(3,3));
            Console.WriteLine("Hello World!");
        }

    }
}
