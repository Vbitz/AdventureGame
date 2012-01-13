using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Registry
{
    public class RegistryItem
    {
        public string Name;
        public bool Directory;

        public RegistryItem(string name)
        {

        }


        public virtual void Access()
        {

        }

        public virtual void SetValue()
        {
            
        }

        public virtual object GetValue()
        {
            return null;
        }
    }

    public class RegistryString : RegistryItem
    {

    }

    public class RegistryNumber : RegistryItem
    {

    }

    public class RegistryMethod : RegistryItem
    {
        public delegate void InvokeMethod(RegistryItem parent);

        private InvokeMethod Method;

        public RegistryMethod(string name, InvokeMethod method)
            : base(name)
        {

        }

        public RegistryMethod(
    }

    public class RegistryFile
    {

    }

    public static class RegistryManager
    {

    }
}
