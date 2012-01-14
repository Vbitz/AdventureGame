using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AdventureGame.Tier1;
using AdventureGame.Tier1.Render;

using AdventureGame.Registry;

namespace AdventureGame.Tier2
{
    class RegistryImage : RegistryItem
    {
        private ExposeImage Img = null;

        public RegistryImage(string name, RegistryItem parent, ExposeImage img)
            : base(name, parent)
        {
            this.Img = img;
        }

        public override object GetValue()
        {
            return Img;
        }

    }
}
