using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleNet.Infrastructure.Logging
{
    public class NLogAdapter:ILogger
    {
        private readonly Logger _logger;

        public NLogAdapter()
        {
            _logger = LogManager.GetCurrentClassLogger();
        }
        public void Log(string message)
        {
            _logger.Log(LogLevel.Info, message);
        }
    }
}
