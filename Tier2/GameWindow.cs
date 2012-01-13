using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AdventureGame.Tier1;

namespace AdventureGame.Tier2
{
    public class GameWindow
    {
        private NativeWindow NWindow;
        public GameWindow(int width, int height)
        {
            this.NWindow = new NativeWindow(width, height);
        }

        public void Run()
        {
            this.NWindow.Run();
        }
    }
}
