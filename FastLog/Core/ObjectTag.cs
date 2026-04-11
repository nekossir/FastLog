using System;
using System.Collections.Generic;
using System.Text;

namespace FastLog.Core
{
    public abstract class ObjectTag
    {
        /// <summary>
        /// Key for <see cref="TagDictionary"/>. Used by <see cref="ObjectEnricher"/> to retrieve tags.
        /// <br/>
        /// It is recommended to write in lowercase to avoid confusion.
        /// </summary>
        public abstract string Key { get; }

        /// implicit cast from tag to dict for convenience
        public static implicit operator TagDictionary(ObjectTag tag)
        {
            TagDictionary dict = new TagDictionary();
            dict[tag.Key] = tag;
            return dict;
        }

        /// so you don't have to write this ugly code by yourself
        /// <summary>
        /// Create <see cref="TagDictionary"/> if more than one tag is present.
        /// </summary>
        public static TagDictionary operator |(ObjectTag left, ObjectTag right)
        {
            TagDictionary dict = new TagDictionary();
            dict[left.Key] = left;
            dict[right.Key] = right;
            return dict;
        }
    }
}
