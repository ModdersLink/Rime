using System.Collections.Generic;
using RimeLib.Frostbite;

namespace RimeLib.Havok
{
    /// <summary>An engine's destruction resources, its breakable bodies' physics, built in another engine's Havok.</summary>
    public interface IHavokDestructionConverter : IEngineInterface
    {
        /// <summary>
        /// The resource with its packfiles built in <paramref name="p_Target"/>'s Havok, its Frostbite
        /// header kept, and what the target's classes have no room for, by what it is and how often.
        /// </summary>
        /// <exception cref="System.NotSupportedException">The resource has something the conversion cannot carry, or the target is not supported.</exception>
        byte[] Convert(byte[] p_Resource, EngineType p_Target, out IReadOnlyDictionary<string, int> p_Dropped);
    }
}
