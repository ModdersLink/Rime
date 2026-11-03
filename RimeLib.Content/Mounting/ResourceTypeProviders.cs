using System;
using System.Collections.Generic;
using RimeLib.Content.Frostbite;
using RimeLib.Frostbite;

namespace RimeLib.Content.Mounting
{
    /// <summary>
    /// Resolves engine interfaces that several subsystems implement per resource type: per type, the
    /// implementation of the newest engine at or below the given one that supports it, as
    /// EngineInterfaceRegistry resolves.
    /// </summary>
    public static class ResourceTypeProviders
    {
        public static Dictionary<ResourceType, T> ByType<T>(EngineType p_Engine, Func<T, IEnumerable<ResourceType>> p_Types) where T : IEngineInterface
        {
            // Newest engine first, so a type goes to the newest implementation that names it.
            var s_ByType = new Dictionary<ResourceType, T>();
            foreach (var s_Provider in EngineInterfaceRegistry.CreateAll<T>(p_Engine))
            foreach (var s_Type in p_Types(s_Provider))
                s_ByType.TryAdd(s_Type, s_Provider);

            return s_ByType;
        }
    }
}
