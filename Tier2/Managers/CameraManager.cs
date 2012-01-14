using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AdventureGame.Registry;
using AdventureGame.Tier1.Managers;

namespace AdventureGame.Tier2.Managers
{
    public static class CameraManager
    {
        private static int CurrentX = 0;
        private static int CurrentY = 0;

        private static int CameraSpeed = 20;

        internal static void Init()
        {
            RegistryItem thisItem = RegistryManager.RootItem.AddDirectoryChild("Camera");
            thisItem.AddChild(new RegistryNumber("Speed", thisItem, CameraSpeed));
            thisItem.AddChild(new RegistryMethod("SetSpeed", thisItem, new RegistryMethod.InvokeMethod(SetSpeed)));
        }

        internal static void SetSpeed(RegistryItem item)
        {
            item
        }

        internal static void KeyPressed(Keys item)
        {
            switch (item)
            {
                case Keys.W:
                    CurrentY -= CameraSpeed;
                    ViewManager.Move(0, -CameraSpeed);
                    break;
                case Keys.S:
                    CurrentY += CameraSpeed;
                    ViewManager.Move(0, CameraSpeed);
                    break;
                case Keys.A:
                    CurrentX -= CameraSpeed;
                    ViewManager.Move(-CameraSpeed, 0);
                    break;
                case Keys.D:
                    CurrentX += CameraSpeed;
                    ViewManager.Move(CameraSpeed, 0);
                    break;
                default:
                    break;
            }
            RegistryInterface.SetNumber("Camera\\X", CurrentX);
            RegistryInterface.SetNumber("Camera\\Y", CurrentY);
        }
    }
}
