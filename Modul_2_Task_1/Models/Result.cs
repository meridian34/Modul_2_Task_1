using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_2_Task_1.Models
{
    internal class Result
    {
        internal Result(bool status, string errMessage)
        {
            Status = status;
            ErrMessage = errMessage;
        }

        internal Result(bool status)
            : this(status, null)
        {
        }

        internal bool Status { get; private set; }

        internal string ErrMessage { get; private set; }
    }
}
