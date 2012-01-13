using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AdventureGame;
using AdventureGame.Tier2;

namespace AdventureGame.Samples.UnitTest
{
    class Program : GameWindow
    {
        public Program()
            : base(800, 600)
        {
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
