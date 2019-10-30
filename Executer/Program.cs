using System;
using System.Diagnostics;
using System.Reflection;
using MyAttribute;

namespace Executer {
    class Program {
        static void Main(string[] args) {
            var a = Assembly.LoadFrom("C:\\Users\\job3_\\Source\\Repos\\LabTaP1920_2\\MyLibrary\\bin\\Debug\\netstandard2.0\\MyLibrary.dll");
            foreach (var type in a.GetTypes()) {
                if (type.IsClass)
                    Console.WriteLine(type.FullName);
                var classInstance = Activator.CreateInstance(type);
                MethodInfo[] methods = type.GetMethods();
                foreach (var m in methods) {
                   // Console.WriteLine(m.ToString());
                    var methodAttributes = m.GetCustomAttributes<ExecuteMe>();

                    foreach (var cust in methodAttributes) {
                        var methodAttrPars = cust.GetMethodPar();
                        if (CheckMethodParams(m, methodAttrPars)) {
                            m.Invoke(classInstance, methodAttrPars);
                        }
                        else {
                            Console.WriteLine("Error in method parameters for method {0}," +
                                              "skip to next method...\n", m.ToString());
                        }

                    }

                }

            }

            Console.ReadLine();
        }

        private static bool CheckMethodParams(MethodInfo m, object[] methodAttrPars) {
            if (m.GetParameters().Length != methodAttrPars.Length)
                return false;
            int i = 0;
            foreach (var parameterInfo in m.GetParameters()) {
                if (parameterInfo.ParameterType != methodAttrPars[i].GetType())
                    return false;
                i++;
            }
            return true;
        }

    }
}
