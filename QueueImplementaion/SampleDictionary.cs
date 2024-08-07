using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueImplementaion
{
    internal class SampleDictionary
    {
        public Dictionary<string, string> Dictionary { get; set; }
        public SampleDictionary()
        {
            Dictionary = new Dictionary<string, string>();
        }

        // A few common methods of Dictionary

        // Add
        public void Add(string key, string value)
        {
            Dictionary.Add(key, value);
        }

        // Remove
        public void Remove(string key)
        {
            if (Dictionary.ContainsKey(key))
            {
                Dictionary.Remove(key);
            }
            else
            {
                Console.WriteLine("Key not found");
            }
        }

        // ContainsKey
        public void ContainsKey(string key)
        {
            if (Dictionary.ContainsKey(key))
            {
                Console.WriteLine("Dictionary contains key " + key);
            }
            else
            {
                Console.WriteLine("Dictionary does not contain key " + key);
            }
        }

        // ContainsValue
        public void ContainsValue(string value)
        {
            if (Dictionary.ContainsValue(value))
            {
                Console.WriteLine("Dictionary contains value " + value);
            }
            else
            {
                Console.WriteLine("Dictionary does not contain value " + value);
            }
        }

        // Set Item
        public void SetItem(string key, string value)
        {
            if (Dictionary.ContainsKey(key))
            {
                Dictionary[key] = value;
            }
            else
            {
                Console.WriteLine("Key not found");
            }
        }

        // Clear
        public void Clear()
        {
            Dictionary.Clear();
        }
    }
}
