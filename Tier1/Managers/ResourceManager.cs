using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AdventureGame.Tier1;

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
        }

        

    }
}
