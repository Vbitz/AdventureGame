using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AdventureGame.Registry;

namespace AdventureGame.Tier2
{
    public class RegistryInterface
    {
        public void CallMethod(string name)
        {
            RegistryManager.CallMethod(name);
        }
    }
}
