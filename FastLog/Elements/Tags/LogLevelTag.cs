using FastLog.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace FastLog.Elements.Tags
{
    public class LogLevelTag : ObjectTag
    {
        public override string Key => "loglevel";

        public LogLevels Level { get; private set; }

        public static LogLevelTag Create(LogLevels level) => new LogLevelTag { Level = level };
    }

    public static class LogLevel
    {
        public static LogLevelTag Debug     => LogLevelTag.Create(LogLevels.Debug);
        public static LogLevelTag Verbose   => LogLevelTag.Create(LogLevels.Verbose);
        public static LogLevelTag Info      => LogLevelTag.Create(LogLevels.Info);
        public static LogLevelTag Warn      => LogLevelTag.Create(LogLevels.Warn);
        public static LogLevelTag Error     => LogLevelTag.Create(LogLevels.Error);
        public static LogLevelTag Severe    => LogLevelTag.Create(LogLevels.Severe);
        public static LogLevelTag Fatal     => LogLevelTag.Create(LogLevels.Fatal);

    }

    public enum LogLevels
    {
        Debug,
        Verbose,
        Info,
        Warn,
        Error,
        Severe,
        Fatal
    }
}
