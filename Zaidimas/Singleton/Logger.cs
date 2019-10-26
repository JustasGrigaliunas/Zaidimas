using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using log4net;
using log4net.Config;

namespace Zaidimas.Singleton
{
    public class Logger
    {
        private static Logger _instance;
        private static ILog _logger;
        private Logger()
        {
            if (_logger == null)
            {


                //_logger = LogManager.GetLogger(nameof(Zaidimas));

                _logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
               
               }
        }

        public static Logger Instance()
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }
            return _instance;
        }

        public void Error(Object message)
        {
            _logger.Error(message);
        }

        public void Info(Object message)
        {
            _logger.Info(message);
 }
    }


}
