using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace AdventureGame.Tier1.Managers
{

    public static class LogManager
    {

        public static void Log(string zone, string level, string message)
        {
            if (Consts.WriteToConsole)
            {
                Console.WriteLine(zone + " : [" + level + "] : " + message);

                Console.ResetColor();
            }

            if (Consts.WriteToFiles)
            {
                if (!Directory.Exists(Consts.BaseDirectory + "Logs\\"))
                {
                    Directory.CreateDirectory(Consts.BaseDirectory + "Logs\\");
                }

                string DateTimeStamp = DateTime.Now.ToString("d-m-y H:m:s");
                File.AppendAllText(Consts.BaseDirectory + "Logs\\" + zone + ".log", DateTimeStamp + " : [" + level + "] : " + message + Environment.NewLine);
            }
        }
    }
}
