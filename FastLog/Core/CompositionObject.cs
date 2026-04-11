using System;
using System.Collections.Generic;
using System.Text;

namespace FastLog.Core
{
    public class CompositionObject
    {
        public static CompositionObject Build(string content) => Build(content, new TagDictionary());

        public static CompositionObject Build(string content, TagDictionary tags)
        {
            CompositionObject obj = new CompositionObject();
            obj.CreationTime = DateTime.Now;
            obj.SourceContent = content;
            obj.Tags = tags;
            return obj;
        }

        private CompositionObject() { }

        public DateTime CreationTime { get; private set; }

        public string SourceContent { get; private set; }

        public string RenderedContent { get; set; }

        public TagDictionary Tags { get; private set; }
    }
}
