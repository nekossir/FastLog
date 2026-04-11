using System;
using System.Collections.Generic;
using System.Text;

namespace FastLog.Core
{
    public abstract class ObjectEnricher
    {
        public abstract string TargetKey { get; }

        public abstract void Enrich(CompositionObject obj);
    }
}
