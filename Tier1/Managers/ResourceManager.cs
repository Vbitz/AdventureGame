using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AdventureGame.Tier1;
using AdventureGame.Tier1.Render;

using SFML;
using SFML.Graphics;

namespace AdventureGame.Tier1.Managers
{
    public static class ResourceManager
    {
        private static Dictionary<string, Image> Images = new Dictionary<string, Image>();
        private static Dictionary<string, Font> Fonts = new Dictionary<string, Font>();

        public static void LoadImage(string filename)
        {
            LogManager.Log("ResourceManager", "Info", "Loading: " + Consts.BaseDirectory + filename);
            Images.Add(filename, new Image(Consts.BaseDirectory + filename));
        }

        public static ExposeImage GetImage(string filename)
        {
            if (Images.ContainsKey(filename))
            {
                return new ExposeImage(Images[filename]);
            }
            else
            {
                LogManager.Log("ResourceManager", "Error", "File " + filename + " is not loaded");
                return null;
            }
        }

    }
}
