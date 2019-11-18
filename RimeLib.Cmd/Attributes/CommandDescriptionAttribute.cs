using System;

namespace RimeLib.Cmd.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CommandDescriptionAttribute : Attribute
    {
        public string Description { get; set; }

        public CommandDescriptionAttribute(string p_Description)
        {
            Description = p_Description;
        }
    }
}
