using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_2_Task_1.Models
{
    using Modul_2_Task_1.Models;

    internal class Actions
    {
        internal Result Create()
        {
            Logger.GetLogger().AddLog($"Start method: {nameof(Create)}", LogType.Info);

            return new Result(true);
        }

        internal Result Update()
        {
            Logger.GetLogger().AddLog($"Skipped logic in method: {nameof(Update)}", LogType.Warning);
            return new Result(true);
        }

        internal Result Remove()
        {
            return new Result(false, "I broke a logic");
        }
    }
}
