using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment7.Classes
{
    internal class AppLogger
    {
        private static AppLogger logger;
        private AppLogger() { }
        public static AppLogger GetLogger()
        {
            if (logger == null) 
                logger = new AppLogger();

            return logger;
        }
    }
}
