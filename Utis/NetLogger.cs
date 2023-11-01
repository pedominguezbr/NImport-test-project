using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using log4net.Config;

namespace NImport.Inf.Rep
{
    public static class NetLogger
    {
        #region Members
        private static readonly ILog logger = LogManager.GetLogger(typeof(NetLogger));
        #endregion

        #region Constructors
        static NetLogger()
        {
            XmlConfigurator.Configure();
        }
        #endregion

        #region Methods
        public static void WriteLog(ELogLevel logLevel, String log)
        {
            if (logLevel.Equals(ELogLevel.Debug))
            {
                logger.Debug(log);
            }
            else if (logLevel.Equals(ELogLevel.Error))
            {
                logger.Error(log);
            }

            else if (logLevel.Equals(ELogLevel.Fatal))
            {
                logger.Fatal(log);
            }

            else if (logLevel.Equals(ELogLevel.Info))
            {
                logger.Info(log);
            }

            else if (logLevel.Equals(ELogLevel.Warning))
            {
                logger.Warn(log);
            }
        }
        #endregion
    }

    public enum ELogLevel
    {

        Debug = 1,

        Error = 2,

        Fatal = 3,

        Info = 4,

        Warning = 5

    }
}
