using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AdventureGame.Registry;

namespace AdventureGame.Tier2
{
    public static class RegistryInterface
    {
        public static void CallMethod(string name)
        {
            RegistryManager.CallMethod(name);
        }

        public static string GetString(string name)
        {
            RegistryItem search = RegistryManager.GetItem(name);
            if (search is RegistryString)
            {
                return (string)search.GetValue();
            }
            return "";
        }

        public static void SetString(string name, string value)
        {
            RegistryItem item = RegistryManager.GetItem(name);
            if (item is RegistryString)
            {
                item.SetValue(value);
            }
        }

        public static float GetNumber(string name)
        {
            RegistryItem search = RegistryManager.GetItem(name);
            if (search is RegistryNumber)
            {
                return (float)search.GetValue();
            }
            return 0;
        }

        public static void SetNumber(string name, float value)
        {
            RegistryItem item = RegistryManager.GetItem(name);
            if (item is RegistryNumber)
            {
                item.SetValue(value);
            }
        }
    }
}
