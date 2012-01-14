using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AdventureGame.Tier1;
using AdventureGame.Tier1.Managers;

using AdventureGame.Tier2.Managers;

using AdventureGame.Registry;

namespace AdventureGame.Tier2
{
    class Tier2NativeWindow : NativeWindow
    {
        Dictionary<Keys, FunctionKey> FKeys = new Dictionary<Keys, FunctionKey>();

        public Tier2NativeWindow(int width, int height)
            : base(width, height)
        {
            FKeys.Add(Keys.F1, FunctionKey.F1);
            FKeys.Add(Keys.F2, FunctionKey.F2);
            FKeys.Add(Keys.F3, FunctionKey.F3);
            FKeys.Add(Keys.F4, FunctionKey.F4);
            FKeys.Add(Keys.F5, FunctionKey.F5);
            FKeys.Add(Keys.F6, FunctionKey.F6);
            FKeys.Add(Keys.F7, FunctionKey.F7);
            FKeys.Add(Keys.F8, FunctionKey.F8);
            FKeys.Add(Keys.F9, FunctionKey.F9);
            FKeys.Add(Keys.F10, FunctionKey.F10);
            FKeys.Add(Keys.F11, FunctionKey.F11);
            FKeys.Add(Keys.F12, FunctionKey.F12);
        }

        public override void Draw()
        {
            this.Clear(0, 0, 0);

            RegistrySceneGraph.DrawAll();

            foreach (Keys item in InputManager.KeysPressed)
            {
                if (FKeys.ContainsKey(item))
                {
                    FunctionHooks.KeyPressed(FKeys[item]);
                }
                CameraManager.KeyPressed(item);
            }
        }
    }

    public class GameWindow
    {
        private Tier2NativeWindow NWindow;
        private RegistryItem RendererItem;

        public GameWindow(int width, int height)
        {
            EngineGlobals.Init();
            CameraManager.Init();
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
