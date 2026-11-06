using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Frostbite;
using RimeLib.Shader;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Rebuilds a shader database's shaders from the mounted shader databases and compares the result with it.")]
    public class RebuildShaderDatabaseCommand : Command
    {
        [CommandArgument(Description = "The shader database, e.g. levels/mp_subway/mp_subway/shaderdb.")]
        public string? Name { get; set; }

        [CommandArgument(Description = "Take the shaders only from the other databases, as a level that doesn't ship has to.", Optional = true)]
        public bool OthersOnly { get; set; }

        [CommandArgument(Description = "Give each shader the solutions of every database that has it, not just the first.", Optional = true)]
        public bool AllSolutions { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Context = (GameContext)p_Context;
            var s_Mounter = s_Context.GetMounter();
            if (string.IsNullOrWhiteSpace(Name) || !s_Mounter.TryGetResource(Name.ToLowerInvariant(), out var s_Reference))
            {
                p_Writer.WriteLine($"Could not find shader database ({Name}).");
                return false;
            }

            var s_Resolver = EngineInterfaceRegistry.Create<IShaderResolver>(s_Mounter.GetEngineType());
            s_Resolver.Initialize(s_Reference.FirstVariant, s_Mounter);
            var s_Shaders = s_Resolver.GetShaderNames().ToList();

            var s_Index = ShaderDatabaseIndex.Get(s_Mounter);
            var s_Builder = s_Index.Builder;
            var s_Databases = s_Index.Databases.Where(p_D => !OthersOnly || p_D.Name != Name.ToLowerInvariant())
                .OrderBy(p_D => p_D.Name == Name.ToLowerInvariant() ? 0 : 1).ThenBy(p_D => p_D.Name, StringComparer.Ordinal).ToList();

            var s_Built = s_Builder.Build(s_Databases.Select(p_D => p_D.Load), s_Shaders, AllSolutions, p_Writer, out var s_Missing);
            p_Writer.WriteLine($"{s_Shaders.Count} shader(s), {s_Missing.Count} in no source database; {s_Built.Length} bytes.");
            foreach (var s_Name in s_Missing)
                p_Writer.WriteLine($"  NO SOURCE {s_Name}");

            var s_Names = s_Shaders.GroupBy(s_Builder.GetShaderKey).ToDictionary(p_G => p_G.Key, p_G => p_G.First());
            s_Builder.Compare(s_Built, Read(s_Reference.FirstVariant), s_Names, p_Writer);
            return true;
        }

        internal static byte[] Read(Content.Mounting.IResourceVariant p_Variant)
        {
            using var s_Reader = p_Variant.GetReader();
            return s_Reader.ReadBytes((int)s_Reader.Length);
        }
    }
}
