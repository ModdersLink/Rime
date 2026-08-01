using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Replaces an existing resource's DATA with a file while keeping the original resource type, meta and id. Use this to override a vanilla resource (eg. a SwfMovie) with modified contents.")]
    internal class ReplaceResourceCommand : Command
    {
        [CommandArgument(Description = "The name of the resource to replace (must exist in a mounted game).")]
        public string? Name { get; set; }

        [CommandArgument(Description = "Id returned by mount_game.")]
        public int Id { get; set; }

        [CommandArgument(Description = "The path to the file containing the NEW resource data.")]
        public FileInfo? FilePath { get; set; }

        // Wraps the original resource variant (for type/meta/id) but serves NEW data
        // from a file. This preserves the resource identity (so the engine matches it
        // against the vanilla resource) while swapping the payload.
        private class ReplacedResource : IResourceObject
        {
            private readonly IResourceVariant m_Original;
            private readonly string m_Path;

            public ReplacedResource(IResourceVariant p_Original, string p_Path)
            {
                m_Original = p_Original;
                m_Path = p_Path;
            }

            public ResourceType GetResourceType() => m_Original.GetResourceType();

            public bool TryGetMeta([NotNullWhen(true)] out byte[]? p_Meta) => m_Original.TryGetMeta(out p_Meta);

            public ResourceRef GetId(string? p_Name = null)
            {
                // Non-CAS FB2 bundles don't store a resource id, so this is usually
                // never called. Fall back to generating one from the name+data if the
                // original variant has none (eg. CAS builds).
                try { return m_Original.GetId(p_Name); }
                catch { return new ResourceRef(p_Name ?? string.Empty, this); }
            }

            public RimeReader GetReader()
            {
                var s_FileStream = File.Open(m_Path, FileMode.Open, FileAccess.Read, FileShare.Read);
                return new RimeReader(s_FileStream);
            }

            public long GetSize() => new FileInfo(m_Path).Length;
        }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                p_Writer.WriteLine("The specified resource could not be found.");
                return false;
            }

            if (!FilePath!.Exists)
            {
                p_Writer.WriteLine("The specified file could not be found.");
                return false;
            }

            var s_BundleContext = (BundleBuildingContext)p_Context;
            var s_SbBuildingContext = (SbBuildingContext?)s_BundleContext.Parent;
            if (s_SbBuildingContext == null)
            {
                p_Writer.WriteLine("Parent context is invalid.");
                return false;
            }

            var s_BaseContext = s_SbBuildingContext.Parent as BaseContext;
            if (s_BaseContext == null)
            {
                p_Writer.WriteLine("SbBuildingContext parent is invalid.");
                return false;
            }

            var s_Mounters = s_BaseContext.GetMounters();
            if (!s_Mounters.TryGetValue(Id, out var s_EngineMounter))
            {
                p_Writer.WriteLine($"Id ({Id}) is not valid, ensure you mounted a game first");
                return false;
            }

            var s_ContextEngineType = s_SbBuildingContext.EngineType;
            if (s_EngineMounter.GetEngineType() != s_ContextEngineType)
            {
                p_Writer.WriteLine($"Cross-engine support has not been added, ({s_EngineMounter.GetEngineType()} != {s_ContextEngineType})");
                return false;
            }

            if (!s_EngineMounter.TryGetResource(Name!, out var s_Resource))
            {
                p_Writer.WriteLine($"Could not find resource ({Name}).");
                return false;
            }

            // Any variant contained in a bundle works, since only its type, meta and id are copied and
            // the data is served here. Requiring a catalog-backed one would exclude the resources the
            // game stores inline, which a cas build could then never override.
            var s_Variant = s_Resource.Variants.FirstOrDefault(p_Resource => p_Resource.GetContainedBundle() != null);

            if (s_Variant == null)
            {
                p_Writer.Write($"Could not find a valid variant of ({Name}).");
                return false;
            }

            var s_HasMeta = s_Variant.TryGetMeta(out var s_MetaBytes);
            var s_MetaHex = s_HasMeta && s_MetaBytes != null
                ? string.Concat(s_MetaBytes.Select(p_B => p_B.ToString("X2")))
                : "<none>";
            p_Writer.WriteLine($"Replacing '{Name}' (type {s_Variant.GetResourceType()}, meta {s_MetaHex}) with {FilePath.Length} bytes from {FilePath.Name}.");
            p_Writer.WriteLine($"  Variants of '{Name}' (sb / bundle):");
            foreach (var s_V in s_Resource.Variants)
                p_Writer.WriteLine($"   - {s_V.GetContainedSuperbundle()} / {s_V.GetContainedBundle() ?? "<none>"}");

            s_BundleContext.AddResource(Name!, new ReplacedResource(s_Variant, FilePath.FullName));

            return true;
        }
    }
}
