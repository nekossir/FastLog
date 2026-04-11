using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace FastLog.Core
{
    /// Neat wrap for making syntax sugar that no one else has
    public class TagDictionary : Dictionary<string, ObjectTag>
    {
        /// I'm pretty sure there will be someone who will use it.
        public void Add(ObjectTag tag)
        {
            base[tag.Key] = tag;
        }

        /// <summary>
        /// I mean, you can use it, but it just uses [ ] under the hood, so why not use them then?
        /// </summary>
        public new void Add(string Key, ObjectTag tag)
        {
            base[Key] = tag;
        }

        /// Some syntax sugar, so you can stack-up tags inline
        public static TagDictionary operator | (TagDictionary left, ObjectTag right)
        {
            left[right.Key] = right;
            return left;
        }
    }
}
