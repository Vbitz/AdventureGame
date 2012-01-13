using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AdventureGame.Registry;

namespace AdventureGame.Tier2.Managers
{
    class RegistrySceneGraph
    {
        public void CreateVector(RegistryItem parent, string name, float x, float y)
        {
            RegistryItem vector = parent.AddDirectoryChild(name);
            vector.AddChild(new RegistryNumber("X", vector, x));
            vector.AddChild(new RegistryNumber("Y", vector, y));
        }

        public RegistryItem CreateRegistryEntity(RegistryItem parent
    }
}
