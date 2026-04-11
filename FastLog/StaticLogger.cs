using FastLog.Core;
using FastLog.Elements.Tags;
using System;
using System.Collections.Generic;
using System.Text;

namespace FastLog
{
    public static class StaticLogger
    {
        private static void BuildLog()
        {

        }

        /// From least to greatest

        public static void Debug()
        {

        }

        public static void Verbose()
        {

        }

        public static void Info(string Content)
        {
            CompositionObject obj = CompositionObject.Build(Content, LogLevel.Info);
        }

        public static void Warn()
        {

        }

        public static void Error() 
        { 

        }

        public static void Severe()
        {

        }

        public static void Fatal()
        {

        }
    }
}
