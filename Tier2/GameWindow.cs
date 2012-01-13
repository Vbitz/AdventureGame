using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AdventureGame.Tier1;
using AdventureGame.Tier1.Managers;

using AdventureGame.Registry;

namespace AdventureGame.Tier2
{
    class Tier2NativeWindow : NativeWindow
    {
        public Tier2NativeWindow(int width, int height)
            : base(width, height)
        {

        }

        public override void Draw()
        {
            RegistryManager.CallMethod("Renderer\\Exit");
        }
    }

    public class GameWindow
    {
        private Tier2NativeWindow NWindow;
        private RegistryItem RendererItem;

        public GameWindow(int width, int height)
        {
            EngineGlobals.Init();
            this.RendererItem = RegistryManager.RootItem.AddDirectoryChild("Renderer");
            this.RendererItem.AddChild(new RegistryMethod("Exit", this.RendererItem, new RegistryMethod.InvokeMethod(Exit)));
            this.NWindow = new Tier2NativeWindow(width, height);
        }

        public void Run()
        {
            this.NWindow.Run();
        }

        public void Exit(RegistryItem parent)
        {
            this.NWindow.Stop();
        }
    }
}
