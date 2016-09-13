using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleNet.Infrastructure.Logging
{
    public static class LoggingFactory
    {
        public static ILogger _logger;

        public static void InitilizeLogger(ILogger logger)
        {
            _logger = logger;
        }

        public static ILogger GetLogger()
        {
            return _logger;
        }
    }
}


