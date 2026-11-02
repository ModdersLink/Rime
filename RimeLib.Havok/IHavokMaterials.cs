using System.Collections.Generic;
using RimeLib.Content.Mounting;

namespace RimeLib.Havok;

/// <summary>
/// The materials a HavokPhysicsData resource's shapes use, from the Frostbite header in front of the
/// Havok packfiles: one packed material value per material the shapes index.
/// </summary>
public interface IHavokMaterials : IEngineInterface
{
    IReadOnlyList<uint> GetMaterialFlagsAndIndices(IResourceObject p_Resource);
}
