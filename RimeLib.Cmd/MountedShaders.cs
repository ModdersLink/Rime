using System;
using System.Collections.Generic;
using System.Linq;
using RimeLib.Content.Mounting;
using RimeLib.Serialization;
using RimeLib.Serialization.Conversion;

namespace RimeLib.Cmd
{
    /// <summary>A mounted game's surface shaders, as stand-ins for another engine's.</summary>
    internal static class MountedShaders
    {
        public const string c_Skinned = "SkinnedMeshAsset";
        public const string c_Composite = "CompositeMeshAsset";
        public const string c_Rigid = "RigidMeshAsset";

        /// <summary>
        /// The shaders of the game's own mesh materials, with the textures its mesh variation
        /// databases bind; only its skinned meshes' where <paramref name="p_Skinned"/>.
        /// </summary>
        public static ShaderStandIns StandIns(IEngineMounter p_Game, IShaderBindings p_Bindings, bool p_Skinned = false) =>
            ByMesh(p_Game, p_Bindings)[p_Skinned ? c_Skinned : ""];

        /// <summary>
        /// The shaders of the game's own mesh materials by the kind of mesh they draw, as a shader
        /// has a skinned or composite permutation only where the game draws such a mesh with it:
        /// a skinned mesh's, a composite mesh's, a rigid or composite mesh's (under the rigid mesh
        /// asset's type) and any mesh's (under ""). Each with the textures the databases bind.
        /// </summary>
        public static IReadOnlyDictionary<string, ShaderStandIns> ByMesh(IEngineMounter p_Game, IShaderBindings p_Bindings)
        {
            var s_Primary = EngineInterfaceRegistry.Create<IPartitionImportReader>(p_Game.GetEngineType());
            var s_Reader = EngineInterfaceRegistry.Create<IPartitionConverter>(p_Game.GetEngineType());
            var s_Pools = new[] { "", c_Skinned, c_Composite, c_Rigid }.ToDictionary(p_K => p_K, _ => new MaterialShaders());
            foreach (var (s_Name, s_Partition) in p_Game.GetPartitions().OrderBy(p_P => p_P.Key, StringComparer.Ordinal))
            {
                var s_Variant = s_Partition.FirstVariant;
                string[] s_Into = s_Primary.ReadPrimaryTypeName(s_Variant) switch
                {
                    "MeshVariationDatabase" => [.. s_Pools.Keys],
                    c_Skinned => ["", c_Skinned],
                    c_Composite => ["", c_Composite, c_Rigid],
                    c_Rigid => ["", c_Rigid],
                    { } s_Type when s_Type.EndsWith("MeshAsset", StringComparison.Ordinal) => [""],
                    _ => [],
                };
                if (s_Into.Length == 0)
                    continue;

                var s_Parsed = s_Reader.FromPartitionObject(s_Name, s_Variant);
                foreach (var s_Pool in s_Into)
                    s_Pools[s_Pool].Add(p_Bindings, s_Parsed);
            }

            return s_Pools.ToDictionary(p_P => p_P.Key, p_P => new ShaderStandIns(p_P.Value.ByShader()));
        }
    }
}
