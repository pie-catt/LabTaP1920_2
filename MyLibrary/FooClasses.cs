using System;
using System.Xml.Serialization;
using MyAttribute;

namespace MyLibrary {
    public class Foo {
        [ExecuteMe()]
        public void M1() {
            Console.WriteLine("M1");
        }

        [ExecuteMe(45)]
        [ExecuteMe(0)]
        [ExecuteMe(3)]
        public void M2(int a) {
            Console.WriteLine("M2 a={0}", a);
        }

        [ExecuteMe("hello", "reflection")]
        public void M3(string s1, string s2) {
            Console.WriteLine("M3 s1={0} s2={1}", s1, s2);
        }



    }

    public class Foo2 {
        [ExecuteMe()]
        public void M1_2() {
            Console.WriteLine("M1");
        }

        [ExecuteMe(1, 2)]
        public void M2_2(int a, int b) {
            Console.WriteLine("M2 a={0} b={1}", a, b);
        }

        [ExecuteMe("hello", "reflection")]
        public void M3_3(string s1, string s2) {
            Console.WriteLine("M3 s1={0} s2={1}", s1, s2);
        }

    }

    public class Foo3 {
        [ExecuteMe("tre")]
        public void M1_3(int a) {
            Console.WriteLine("M1");
        }

        [ExecuteMe()]
        public void M11024() {
            Console.WriteLine("M1024");
        }
    }


}
