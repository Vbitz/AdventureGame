using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AdventureGame.Registry;
using AdventureGame.Tier1;
using AdventureGame.Tier1.Managers;
using AdventureGame.Tier1.Render;

namespace AdventureGame.Tier2.Managers
{
    public static class RegistrySceneGraph
    {
        internal static bool Active = false;

        public static void Init()
        {
            Active = true;
            RegistryManager.RootItem.AddDirectoryChild("Render");
        }

        public static void CreateVector(RegistryItem parent, string name, float x, float y)
        {
            RegistryItem vector = parent.AddDirectoryChild(name);
            vector.AddChild(new RegistryNumber("X", vector, x));
            vector.AddChild(new RegistryNumber("Y", vector, y));
        }

        public static RegistryItem CreateRegistryEntity(RegistryItem parent, string name, string filename, float xloc, float yloc)
        {
            RegistryItem entity = parent.AddDirectoryChild(name);
            CreateVector(entity, "Location", xloc, yloc);
            entity.AddChild(new RegistryMethod("Draw", entity, new RegistryMethod.InvokeMethod(DrawBasic)));
            entity.AddChild(new RegistryImage("Image", entity, ResourceManager.GetImage(filename)));
            return entity;
        }

        internal static void DrawBasic(RegistryItem item)
        {
            RegistryItem loc = item.GetChild("Location");
            Graphics.DrawImage(item.GetChild("Image").GetValue(), loc.GetChild("X").GetValue(), loc.GetChild("Y").GetValue());
        }

        public static void CreateEntity(string name, string imgFile, float x, float y)
        {
            ResourceManager.LoadImage(imgFile);
            CreateRegistryEntity(RegistryManager.GetItem("Render"), name, imgFile, x, y);
        }

        public static void DrawAll()
        {
            if (!Active)
            {
                return;
            }
            RegistryManager.InvokeAll("Render", "Draw");
        }
    }
}
