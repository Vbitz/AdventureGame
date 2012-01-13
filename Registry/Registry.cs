using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace AdventureGame.Registry
{
    public class RegistryItem
    {
        public string Name;
        public bool Directory;

        public RegistryItem Parent;

        public RegistryItem(string name, RegistryItem parent)
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
        public RegistryString(string name, RegistryItem parent, string value)
            : base(name, parent)
        {

        }
    }

    public class RegistryNumber : RegistryItem
    {
        private float Value;

        public RegistryNumber(string name, RegistryItem parent, float value)
            : base(name, parent)
        {

        }

        public override object GetValue()
        {
            return this.Value;
        }

        public override void SetValue()
        {
            base.SetValue();
        }
    }

    public class RegistryMethod : RegistryItem
    {
        public delegate void InvokeMethod(RegistryItem parent);

        private InvokeMethod Method;

        public RegistryMethod(string name, RegistryItem parent, InvokeMethod method)
            : base(name, parent)
        {
            this.Method = method;
        }

        public override void Access()
        {
            this.Method(this.Parent);
        }
    }

    public class RegistryFile : RegistryItem
    {
        private FileInfo Value;

        public RegistryFile(string name, RegistryItem parent, string filename)
            : base(name, parent)
        {

        }
    }

    public static class RegistryManager
    {

    }
}
