using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SFML;
using SFML.Graphics;

namespace AdventureGame.Tier1.Render
{
    public class ExposeImage
    {
        private Image Img;

        internal ExposeImage(Image img)
        {
            this.Img = img;
        }
    }
}
