using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_CallBack_
{
    public static class ClassA
    {
        public static void MethodA(string value)
        {
            Console.WriteLine(value);
        }
    }
    public static class ClassB
    {
        public static void MethodB(string value)
        {
            Console.WriteLine(value);
        }
    }
}
