using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AdventureGame;
using AdventureGame.Tier2;
using AdventureGame.Tier2.Managers;

namespace AdventureGame.Samples.UnitTest
{
    class Program : GameWindow
    {
        public Program()
            : base(1280, 800)
        {
            RegistrySceneGraph.Init();
            for (int x = 0; x < 40; x++)
            {
                for (int y = 0; y < 40; y++)
                {
                    RegistrySceneGraph.CreateEntity("Testing" + x.ToString() + " " + y.ToString(), "Test.png", x*20, y*20);
                }
            }
            FunctionHooks.Register(FunctionKey.F2, new FunctionMethod(ExitApp));
        }

        public void ExitApp()
        {
            RegistryInterface.CallMethod("Renderer\\Exit");
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }
    }
}
