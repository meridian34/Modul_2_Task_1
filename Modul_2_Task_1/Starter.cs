using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Modul_2_Task_1.Models
{
    internal class Starter
    {
        internal void Run()
        {
            Actions actions = new Actions();
            Result result;
            for (int i = 0; i < 100; i++)
            {
                int rnd = new Random().Next(1, 4);
                switch (rnd)
                {
                    case 1:
                        result = actions.Create();
                        break;
                    case 2:
                        result = actions.Update();
                        break;
                    case 3:
                        result = actions.Remove();
                        break;
                    default:
                        result = null;
                        break;
                }

                if (!result.Status)
                {
                    Logger.GetLogger().AddLog($"Action failed by a reason: {result.ErrMessage}", LogType.Error);
                }
            }

            File.WriteAllText($"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}//log.txt", Logger.GetLogger().GetLog());
        }
    }
}
