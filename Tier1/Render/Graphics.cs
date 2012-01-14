using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SFML;
using SFML.Graphics;

namespace AdventureGame.Tier1.Render
{
    public class Graphics
    {
        private static  Sprite TemplateSprite = new Sprite();

        private static void ResetTemplate()
        {
            TemplateSprite.Position = new Vector2(0, 0);
            TemplateSprite.Image = null;
        }

        public static void DrawImage(object expImage, object xloc, object yloc)
        {
            ResetTemplate();

            ExposeImage img = (ExposeImage)expImage;
            float x = (float)xloc;
            float y = (float)yloc;

            TemplateSprite.Image = img.Img;

            NativeWindow.Singiltion.RWindow.Draw(TemplateSprite);
        }
    }
}
