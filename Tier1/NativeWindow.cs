using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AdventureGame.Tier1.Managers;

using SFML;
using SFML.Graphics;
using SFML.Window;

namespace AdventureGame.Tier1
{
    public class NativeWindow
    {
        internal NativeWindow Singiltion = null;

        private RenderWindow RWindow;
        private bool Running = false;

        public NativeWindow(int width, int height)
        {
            this.RWindow = new RenderWindow(new VideoMode(800, 600), "Engine Window");
            this.RWindow.KeyPressed += new EventHandler<KeyEventArgs>(RWindow_KeyPressed);
            this.RWindow.Closed += new EventHandler(RWindow_Closed);
            Singiltion = this;
        }

        void RWindow_Closed(object sender, EventArgs e)
        {
            this.Stop();
        }

        void RWindow_KeyPressed(object sender, KeyEventArgs e)
        {
            InputManager.KeyPress(e.Code);
        }

        public void Run()
        {
            this.Running = true;
            while (this.Running)
            {
                InputManager.NewFrame();

                this.RWindow.DispatchEvents();

                this.Draw();

                this.RWindow.Display();
            }
        }

        public virtual void Draw()
        {

        }

        public void Stop()
        {
            this.Running = false;
        }
    }
}
