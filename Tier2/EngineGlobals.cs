using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AdventureGame.Registry;

namespace AdventureGame.Tier2
{
    public static class EngineGlobals
    {
        private static bool Inited = false;

        public static void Init()
        {
            if (Inited)
            {
                return;
            }
            Inited = true;

            RegistryManager.InitRegistry();
        }
    }
}
