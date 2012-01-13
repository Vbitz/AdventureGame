using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AdventureGame.Tier1;

using AdventureGame.Registry;

namespace AdventureGame.Tier2
{
    class RegistryImage : RegistryItem
    {
        public RegistryImage(string name, RegistryItem parent)
            : base(name, parent)
        {

        }

        public override object GetValue()
        {
            return base.GetValue();
        }

    }
}
