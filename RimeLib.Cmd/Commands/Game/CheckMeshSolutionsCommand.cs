using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Frostbite;
using RimeLib.Mesh.Sets;
using RimeLib.Serialization;
using RimeLib.Serialization.Conversion;
using RimeLib.Shader;

namespace RimeLib.Cmd.Commands.Game
{
    /// <summary>
    /// Checks which mesh subsets a shader database can draw: the game draws a subset only with a
    /// solution of its material's shader for the subset's vertex declaration, and skips it otherwise.
    /// </summary>
    [CommandDescription("Counts the mounted bundles' mesh subsets a shader database has a solution for (their material's shader with their vertex declaration); the game skips the others.")]
    public class CheckMeshSolutionsCommand : Command
    {
        [CommandArgument(Description = "The shader database resource, e.g. levels/mp_prison/mp_prison/shaderdb, or * for all mounted ones.")]
        public string Name { get; set; } = "";

        [CommandArgument(Description = "Prefix of the bundles whose meshes to check, e.g. win32/levels/mp_prison/.")]
        public string Bundles { get; set; } = "";

        [CommandArgument(Description = "A directory of partition JSON dumps; only meshes with a dump there are checked. Empty for all.", Optional = true)]
        public string Only { get; set; } = "";

        [CommandArgument(Description = "How many undrawn shader and declaration pairs to list.", Optional = true)]
        public int List { get; set; } = 30;

        [CommandArgument(Description = "Comma-separated parts of the names of meshes whose every subset to list.", Optional = true)]
        public string Detail { get; set; } = "";

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Mounter = ((GameContext)p_Context).GetMounter();
            var s_Engine = s_Mounter.GetEngineType();
            var s_Builder = EngineInterfaceRegistry.Create<IShaderDatabaseBuilder>(s_Engine);
            var s_Codec = EngineInterfaceRegistry.Create<IMeshSetCodec>(s_Engine);
            var s_Bindings = EngineInterfaceRegistry.Create<IShaderBindings>(s_Engine);
            var s_Reader = EngineInterfaceRegistry.Create<IPartitionConverter>(s_Engine);
            ShaderDeclarations s_Declarations;
            if (Name == "*")
                s_Declarations = ShaderDatabaseIndex.Get(s_Mounter).Declarations;
            else if (s_Mounter.TryGetResource(Name.ToLowerInvariant(), out var s_Database))
                s_Declarations = s_Builder.GetDeclarations(MountedTextures.Read(s_Database.FirstVariant));
            else
            {
                p_Writer.WriteLine($"No shader database {Name} is mounted.");
                return false;
            }

            p_Writer.WriteLine($"{s_Declarations.ByShader.Count} shader(s), {s_Declarations.Declarations.Count} declaration(s); {s_Declarations.StateHashMismatches} solution(s) whose state hash is not their state's.");

            // A declaration read back must hash as stored, or a mesh's hash says nothing.
            var s_Rehashed = s_Declarations.Declarations.Count(p_D =>
            {
                var (s_Elements, s_Streams) = s_Codec.ReadDeclaration(p_D.Value);
                return s_Codec.DeclarationHash(new MeshSubsetModel { MaterialName = "", Elements = s_Elements, Streams = s_Streams, TexCoordRatios = new float[6] }) == p_D.Key;
            });
            p_Writer.WriteLine($"{s_Rehashed} of the declarations hash as stored when read back.");

            int s_Meshes = 0, s_AllDrawn = 0, s_NoneDrawn = 0, s_Subsets = 0, s_Drawn = 0, s_NoShader = 0, s_Unknown = 0;
            var s_Undrawn = new Dictionary<(string Shader, string Layout), (int Count, string Mesh)>();
            var s_Unshaded = new SortedSet<string>(StringComparer.OrdinalIgnoreCase);
            var s_Checked = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (var s_Bundle in s_Mounter.GetMountedBundles().Where(p_B => p_B.StartsWith(Bundles, StringComparison.OrdinalIgnoreCase)))
            foreach (var (s_Name, _) in s_Mounter.GetResourcesInBundle(s_Bundle).Where(p_R => p_R.ResourceType == ResourceType.MeshSet))
            {
                if (!s_Checked.Add(s_Name) || (Only.Length > 0 && !File.Exists(Path.Combine(Only, s_Name.ToLowerInvariant() + ".json")))
                    || !s_Mounter.TryGetResource(s_Name, out var s_Resource) || !s_Mounter.TryGetPartition(s_Name.ToLowerInvariant(), out var s_Partition)
                    || !s_Resource.FirstVariant.TryGetMeta(out var s_Meta))
                    continue;

                var s_Shaders = s_Bindings.MeshShaders(s_Reader.FromPartitionObject(s_Name, s_Partition.FirstVariant));
                var s_Model = s_Codec.Decode(new MeshSetPayload(MountedTextures.Read(s_Resource.FirstVariant), s_Meta));
                var s_Detail = Detail.Split(',', StringSplitOptions.RemoveEmptyEntries).Any(p_D => s_Name.Contains(p_D, StringComparison.OrdinalIgnoreCase));
                if (s_Detail)
                    p_Writer.WriteLine($"{s_Name}: {s_Model.Lods.Count} LOD(s), {s_Shaders.Count} material(s)");
                int s_Here = 0, s_HereDrawn = 0;
                foreach (var (s_Lod, l) in s_Model.Lods.Select((p_L, l) => (p_L, l)))
                foreach (var (s_Subset, i) in s_Lod.Subsets.Select((p_S, i) => (p_S, i)))
                {
                    ++s_Here;
                    var s_Shader = s_Subset.MaterialIndex < s_Shaders.Count ? s_Shaders[(int)s_Subset.MaterialIndex] : null;
                    var s_ShaderName = s_Shader != null && s_Mounter.TryGetPartitionByGuid(s_Shader.Partition, out var s_N, out _) ? s_N : null;
                    var s_Hash = s_Codec.DeclarationHash(s_Subset);
                    if (s_Detail)
                        p_Writer.WriteLine($"  LOD {l} ({s_Lod.Kind}, chunk {s_Lod.ChunkId}) subset {i} {s_Subset.MaterialName}: material {s_Subset.MaterialIndex}, " +
                            $"{s_ShaderName ?? s_Shader?.ToString() ?? "no shader"}, {s_Hash:X8} in {s_Subset.Streams.Count} stream(s), " +
                            $"{(s_ShaderName != null && s_Declarations.Draws(s_Builder.GetShaderKey(s_ShaderName), s_Hash) ? "drawn" : "undrawn")}");
                    if (s_ShaderName == null)
                    {
                        ++s_NoShader;
                        s_Unshaded.Add($"{s_Name} material {s_Subset.MaterialIndex}: {s_Shader?.ToString() ?? "none"}");
                        continue;
                    }

                    var s_Key = s_Builder.GetShaderKey(s_ShaderName);
                    if (s_Declarations.Draws(s_Key, s_Hash))
                    {
                        ++s_HereDrawn;
                        continue;
                    }

                    if (!s_Declarations.Declarations.ContainsKey(s_Hash))
                        ++s_Unknown;
                    var s_Layout = $"{s_Hash:X8} " + string.Join(" ", s_Subset.Elements.Select(p_E => $"{p_E.Usage}:{p_E.Format}@{p_E.Offset}")) + $" /{s_Subset.VertexStride}";
                    s_Undrawn[(s_ShaderName, s_Layout)] = (s_Undrawn.GetValueOrDefault((s_ShaderName, s_Layout)).Count + 1, s_Undrawn.GetValueOrDefault((s_ShaderName, s_Layout)).Mesh ?? s_Name);
                }

                ++s_Meshes;
                s_Subsets += s_Here;
                s_Drawn += s_HereDrawn;
                if (s_HereDrawn == s_Here)
                    ++s_AllDrawn;
                else if (s_HereDrawn == 0)
                    ++s_NoneDrawn;
            }

            foreach (var ((s_Shader, s_Layout), (s_Count, s_Mesh)) in s_Undrawn.OrderByDescending(p_U => p_U.Value.Count).Take(List))
                p_Writer.WriteLine($"  {s_Count,5} undrawn: {s_Shader} with {s_Layout}, e.g. in {s_Mesh}");

            foreach (var s_Mesh in s_Unshaded.Take(List))
                p_Writer.WriteLine($"  no shader: {s_Mesh}");

            p_Writer.WriteLine($"check_mesh_solutions: {s_Meshes} mesh(es): {s_AllDrawn} drawn whole, {s_NoneDrawn} not at all, {s_Meshes - s_AllDrawn - s_NoneDrawn} in part; " +
                $"{s_Drawn}/{s_Subsets} subset(s) drawn, {s_NoShader} without a shader, {s_Unknown} with a declaration the database has for no shader.");
            return true;
        }
    }
}
