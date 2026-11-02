using System;
using RimeLib.Frostbite;

namespace RimeLib.Cmd.Attributes
{
    /// <summary>
    /// A command an engine project contributes to a context: the context registers it when its
    /// engine is listed. A command lives in the oldest engine project it works for and lists the
    /// later engines it still fits, like the engine interfaces.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class EngineCommandAttribute : Attribute
    {
        /// <summary>The context type that registers the command (GameContext, BundleBuildingContext, ...).</summary>
        public Type Context { get; }

        public EngineType[] Engines { get; }

        public EngineCommandAttribute(Type p_Context, params EngineType[] p_Engines)
        {
            Context = p_Context;
            Engines = p_Engines;
        }
    }
}
