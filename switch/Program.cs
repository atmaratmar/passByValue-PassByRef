using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByValue

{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 10;
            valuetype(value);
            Console.WriteLine(value);
            PassByRef(ref value);
            Console.WriteLine(value);
            valuetype(value);
            Console.WriteLine(value);

        }
        static void valuetype(int myvalue)
        {
            myvalue += 5;
            Console.WriteLine("my value={0}",myvalue);
        }
        static void PassByRef(ref int myrefvalue)
        {
            myrefvalue += 5;
            Console.WriteLine("Myrefvalue {0}",myrefvalue);
        }
    }
}
