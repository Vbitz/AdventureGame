using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AdventureGame.Registry;
using AdventureGame.Tier1;
using AdventureGame.Tier1.Render;

namespace AdventureGame.Tier2.Managers
{
    public class RegistrySceneGraph
    {
        public void CreateVector(RegistryItem parent, string name, float x, float y)
        {
            RegistryItem vector = parent.AddDirectoryChild(name);
            vector.AddChild(new RegistryNumber("X", vector, x));
            vector.AddChild(new RegistryNumber("Y", vector, y));
        }

        public RegistryItem CreateRegistryEntity(RegistryItem parent, string name, float xloc, float yloc)
        {
            RegistryItem entity = parent.AddDirectoryChild(name);
            CreateVector(entity, "Location", xloc, yloc);
            entity.AddChild(new RegistryMethod("Draw", entity, new RegistryMethod.InvokeMethod(DrawBasic)));
            return entity;
        }

        internal static void DrawBasic(RegistryItem item)
        {
        }
    }
}
