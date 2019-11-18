using System;
using System.Runtime.CompilerServices;

namespace RimeLib.Cmd.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CommandArgumentAttribute : Attribute
    {
        public bool Optional { get; set; } = false;
        public string Description { get; set; } = "";
        public int Order { get; }

        public CommandArgumentAttribute([CallerLineNumber] int p_Order = 0)
        {
            Order = p_Order;
        }
    }
}
