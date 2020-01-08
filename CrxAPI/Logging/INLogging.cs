using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrxAPI
{
    public interface INLogging
    {
        void Information(string message);
        void Warning(string message);
        void Debug(string message);
        void CustomError(string message);
        void Error(Exception ex);
     }
}
