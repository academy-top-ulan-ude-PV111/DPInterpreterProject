using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPInterpreterProject
{
    internal class Context
    {
        Dictionary<string, int> vars;
        public Context() 
        {
            vars = new();
        }

        public void SetVar(string name, int value)
        {
            if(vars.ContainsKey(name))
                vars[name] = value;
            else
                vars.Add(name, value);
        }

        public int GetVar(string name)
        {
            return vars[name];
        }

    }
}
