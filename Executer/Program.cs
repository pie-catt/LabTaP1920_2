using System;
using System.Reflection;
using MyAttribute;

namespace Executer {
    class Program {
        static void Main(string[] args) {
            var a = Assembly.LoadFrom("MyLibrary.dll");
            foreach (var type in a.GetTypes()) {
                if (type.IsClass)
                    Console.WriteLine(type.FullName);
                var classInstance = Activator.CreateInstance(type);
                MethodInfo[] methods = type.GetMethods();
                foreach (var m in methods) {
                    Console.WriteLine(m.ToString());
                    var methodAttributes = m.GetCustomAttributes<ExecuteMe>();

                    foreach (var cust in methodAttributes) {
                        var methodPars = cust.GetMethodPar();
                        m.Invoke(classInstance, methodPars);
                    }

                }

            }

            Console.ReadLine();
        }

    }
}
