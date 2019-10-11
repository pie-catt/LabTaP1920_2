using System;

namespace MyAttribute {
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class ExecuteMe : Attribute
    {
        private readonly object[] _methodPar;

        public ExecuteMe(params object[] par) {
            this._methodPar = par;
        }

        public object[] GetMethodPar()
        {
            return this._methodPar;
        }
    }
}
