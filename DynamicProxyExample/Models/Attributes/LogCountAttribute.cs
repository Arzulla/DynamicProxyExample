using System;

namespace DynamicProxyExample.Models.Attributes
{
    public class LogCountAttribute:Attribute
    {
        public string Name { get; private set; }

        public LogCountAttribute(string name)
        {
            Name = name;
        }
    }
}
