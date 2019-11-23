using System;
using RimeLib.Frostbite;

namespace RimeLib.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class EngineSupportAttribute : Attribute
    {
        public EngineType[] SupportedEngines { get; set; }

        public EngineSupportAttribute(params EngineType[] p_SupportedEngines)
        {
            SupportedEngines = p_SupportedEngines;
        }
    }
}
