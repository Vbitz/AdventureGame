using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureGame.Tier2
{
    public enum FunctionKey
    {
        F1,
        F2,
        F3,
        F4,
        F5,
        F6,
        F7,
        F8,
        F9,
        F10,
        F11,
        F12
    }

    public delegate void FunctionMethod();

    public static class FunctionHooks
    {
        private static Dictionary<FunctionKey, FunctionMethod> Hooks = new Dictionary<FunctionKey, FunctionMethod>();

        public static void KeyPressed(FunctionKey key)
        {
            if (Hooks.ContainsKey(key))
            {
                Hooks[key]();
            }
        }

        public static void Register(FunctionKey functionKey, FunctionMethod functionMethod)
        {
            if (Hooks.ContainsKey(functionKey))
            {
                Hooks[functionKey] = functionMethod;
            }
            else
            {
                Hooks.Add(functionKey, functionMethod);
            }
        }
    }
}
