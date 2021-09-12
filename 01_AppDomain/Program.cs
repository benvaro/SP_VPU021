using System;
using System.Linq;
using System.Reflection;

namespace _01_AppDomain
{
    class Program
    {
        static void Main(string[] args)
        {
            //var a = 10; // int
            ////a = "hello";

            //dynamic b = 12; // runtime
            //b = "hello";

            //Console.WriteLine(b.GetType());
            //b = new List<string>();
            
            //Console.WriteLine(b.GetType());

            // домен додатку
            //AppDomain domain = AppDomain.CreateDomain("MathLibrary");

            var domain = AppDomain.CurrentDomain;
            //var assemblies = domain.GetAssemblies();
            var assemblies = from asm in domain.GetAssemblies().ToList()
                             select asm;

            foreach (Assembly asm in assemblies.OrderByDescending(x => x.GetName().Name))
            {
                Console.WriteLine(asm.FullName);
            }
        }
    }
}
