using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            var s_Providers = new List<T>();
            foreach (var s_Assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                Type[] s_Types;
                try
                {
                    s_Types = s_Assembly.GetTypes();
                }
                catch (ReflectionTypeLoadException s_Ex)
                {
                    s_Types = s_Ex.Types.Where(p_T => p_T != null).ToArray()!;
                }

                foreach (var s_Type in s_Types.Where(p_T => !p_T.IsAbstract && !p_T.IsInterface && typeof(T).IsAssignableFrom(p_T) && p_T.GetConstructor(Type.EmptyTypes) != null))
                {
                    var s_Provider = (T)Activator.CreateInstance(s_Type)!;
                    var s_Supported = s_Provider.GetSupportedEngines();
                    if (s_Supported.Contains(p_Engine) && s_Supported.Min() <= p_Engine)
                        s_Providers.Add(s_Provider);
                }
            }

            return s_Providers
                .SelectMany(p_P => p_Types(p_P).Select(p_T => (Type: p_T, Provider: p_P)))
                .GroupBy(p_E => p_E.Type)
                .ToDictionary(p_G => p_G.Key, p_G => p_G.OrderByDescending(p_E => p_E.Provider.GetSupportedEngines().Min()).First().Provider);
        }
    }
}
