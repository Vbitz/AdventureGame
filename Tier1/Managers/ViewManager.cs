using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SFML;
using SFML.Graphics;

namespace AdventureGame.Tier1.Managers
{
    public static class ViewManager
    {

        public static void Move(int x, int y)
        {
            NativeWindow.Singiltion.RWindow.CurrentView.Move(new Vector2(x, y));
        }
    }
}
