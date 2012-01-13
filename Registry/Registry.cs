using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

using AdventureGame.Tier1.Managers;

namespace AdventureGame.Registry
{
    public class RegistryItem
    {
        public string Name;
        public bool Directory;

        public RegistryItem Parent;

        private List<RegistryItem> Children = new List<RegistryItem>();

        public RegistryItem(string name, RegistryItem parent)
        {
            this.Name = name;
            this.Parent = parent;
        }

        public virtual void Access()
        {

        }

        public virtual void SetValue(object value)
        {

        }

        public virtual object GetValue()
        {
            return null;
        }

        public RegistryItem GetChild(string name)
        {
            if (!this.Directory)
            {
                return null;
            }
            foreach (RegistryItem item in this.Children)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }
            return null;
        }

        public void AddChild(RegistryItem item)
        {
            if (this.GetChild(item.Name) != null)
            {
                LogManager.Log("Registry", "Error", "Node: " + item.Name + " already exists");
            }
            else
            {
                this.Children.Add(item);
            }
        }

        public RegistryItem AddDirectoryChild(string name)
        {
            RegistryItem newItem = new RegistryItem(name, this);
            newItem.Directory = true;
            this.AddChild(newItem);
            return newItem;
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

        public override void SetValue(object value)
        {
            if (value is float | value is int | value is long)
            {
                this.Value = (float)value;
                return;
            }
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
            this.Value = new FileInfo(filename);
            if (!this.Value.Exists)
            {
                LogManager.Log("Registry", "Warning", filename + " : Does not Exist");
            }
        }

        public string ReadAllAsString()
        {
            return File.ReadAllText(Value.FullName);
        }

        public byte[] ReadAllAsBytes()
        {
            return File.ReadAllBytes(this.Value.FullName);
        }
    }

    public static class RegistryManager
    {
        public static RegistryItem RootItem;
        public static RegistryItem ConfigDir;

        public static void InitRegistry()
        {
            RootItem = new RegistryItem("Root", null);
            RootItem.Directory = true;
            ConfigDir = RootItem.AddDirectoryChild("Config");
        }

        public static void CallMethod(string name)
        {
            string[] tokens = name.Split('\\');
            RegistryItem directory = RootItem;
            for (int i = 0; i < tokens.Length -1; i++)
            {
                Console.WriteLine("Opening: " + name);
                directory = directory.GetChild(tokens[i]);
            }
            Console.WriteLine("Calling: " + name);
            directory.GetChild(tokens[tokens.Length - 1]).Access();
        }
    }
}
