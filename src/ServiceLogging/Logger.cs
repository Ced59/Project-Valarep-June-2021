using InterfacesContrats.Logger;
using NLog;
using System;

namespace ServiceLogging
{
    public class Logger : ILoggable
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();

        public void LogAvertissement(string message)
        {
            logger.Warn(message);
        }

        public void LogDebug(string message)
        {
            logger.Debug(message);
        }

        public void LogErreur(string message)
        {
            logger.Error(message);
        }

        public void LogInfo(string message)
        {
            logger.Info(message);
        }
    }
}