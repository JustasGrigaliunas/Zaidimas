using System;
using System.Collections.Generic;
using System.Text;

namespace Zaidimas.Singleton
{
    public class Logger
    {
        private static Logger _instance;
        static Logger() { }
        private Logger() { }

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
            _instance.Error(message);
        }

        public void Info(Object message)
        {
            _instance.Info(message);
 }
    }


}
