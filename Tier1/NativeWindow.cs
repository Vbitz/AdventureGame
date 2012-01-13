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
        private RenderWindow RWindow;
        private bool Running = false;

        public NativeWindow(int width, int height)
        {
            this.RWindow = new RenderWindow(new VideoMode(800, 600), "Engine Window");
            this.RWindow.KeyPressed += new EventHandler<KeyEventArgs>(RWindow_KeyPressed);
            this.RWindow.KeyReleased += new EventHandler<KeyEventArgs>(RWindow_KeyReleased);
            this.RWindow.Closed += new EventHandler(RWindow_Closed);
        }

        void RWindow_Closed(object sender, EventArgs e)
        {
            this.Stop();
        }

        void RWindow_KeyReleased(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        void RWindow_KeyPressed(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            this.Running = true;
            while (this.Running)
            {
                this.RWindow.DispatchEvents();

                this.RWindow.Display();
            }
            this.RWindow.Close();
        }

        public void Stop()
        {
            this.Running = false;
        }
    }
}
