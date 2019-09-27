using System;

namespace MyAttribute {
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class ExecuteMe : Attribute {
        private object[] _methodPar;

        public ExecuteMe(params object[] par) {
            this._methodPar = par;
        }
    }
}
