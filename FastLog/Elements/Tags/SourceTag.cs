using FastLog.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace FastLog.Elements.Tags
{
    public class SourceTag : ObjectTag
    {
        public override string Key => "source";

        public string Source { get; private set; }

        public static SourceTag Create(string source) => new SourceTag { Source = source };
    }
}
