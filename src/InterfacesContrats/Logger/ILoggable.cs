using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesContrats.Logger
{
    public interface ILoggable
    {
        void LogInfo(string message);

        void LogAvertissement(string message);

        void LogDebug(string message);

        void LogErreur(string message);
    }
}