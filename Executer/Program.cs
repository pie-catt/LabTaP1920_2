﻿using System;
using System.Reflection;

namespace Executer {
    class Program {
        static void Main(string[] args) {
            var a = Assembly.LoadFrom("MyLibrary.dll");
            foreach (var type in a.GetTypes()) {
                if (type.IsClass)
                    Console.WriteLine(type.FullName);
            }

            Console.ReadLine();
        }

    }
}
