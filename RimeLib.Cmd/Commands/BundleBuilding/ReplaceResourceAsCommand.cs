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
    [CommandDescription("Adds a NEW resource under <new_name> that reuses an EXISTING resource's type+meta (<orig_name>) but serves data from a file. Unlike replace_resource (same name -> override), this gives a uniquely-named copy, so it does NOT collide with the vanilla resource. Use to add a modified physics/havok resource under a fresh name and redirect a reference to it at runtime.")]
    internal class ReplaceResourceAsCommand : Command
    {
        [CommandArgument(Description = "The name of the EXISTING resource to copy type+meta from (must exist in a mounted game).")]
        public string? OrigName { get; set; }

        [CommandArgument(Description = "The NEW resource name to create.")]
        public string? NewName { get; set; }

        [CommandArgument(Description = "Id returned by mount_game.")]
        public int Id { get; set; }

        [CommandArgument(Description = "The path to the file containing the NEW resource data.")]
        public FileInfo? FilePath { get; set; }

        [CommandArgument(Description = "Optional META override as a hex string (e.g. for a resized HavokPhysicsData whose section sizes changed). If omitted, the original resource's meta is reused.", Optional = true)]
        public string? MetaHex { get; set; }

        // Wraps an original resource variant (type/meta) but serves NEW data from a file,
        // published under a DIFFERENT name (no override of the original).
        private class RenamedResource : IResourceObject
        {
            private readonly IResourceVariant m_Original;
            private readonly string m_Path;
            private readonly string m_Name;
            private readonly byte[]? m_MetaOverride;

            public RenamedResource(IResourceVariant p_Original, string p_Path, string p_Name, byte[]? p_MetaOverride = null)
            {
                m_Original = p_Original;
                m_Path = p_Path;
                m_Name = p_Name;
                m_MetaOverride = p_MetaOverride;
            }

            public ResourceType GetResourceType() => m_Original.GetResourceType();

            public bool TryGetMeta([NotNullWhen(true)] out byte[]? p_Meta)
            {
                if (m_MetaOverride != null) { p_Meta = m_MetaOverride; return true; }
                return m_Original.TryGetMeta(out p_Meta);
            }

            public ResourceRef GetId(string? p_Name = null)
            {
                try { return m_Original.GetId(p_Name ?? m_Name); }
                catch { return new ResourceRef(p_Name ?? m_Name, this); }
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
            if (string.IsNullOrWhiteSpace(OrigName) || string.IsNullOrWhiteSpace(NewName))
            {
                p_Writer.WriteLine("orig_name and new_name are required.");
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

            if (s_EngineMounter.GetEngineType() != s_SbBuildingContext.EngineType)
            {
                p_Writer.WriteLine("Cross-engine support has not been added.");
                return false;
            }

            if (!s_EngineMounter.TryGetResource(OrigName!, out var s_Resource))
            {
                p_Writer.WriteLine($"Could not find resource ({OrigName}).");
                return false;
            }

            IResourceVariant? s_Variant;
            if (s_BundleContext.Cas())
                s_Variant = s_Resource.Variants.FirstOrDefault(p_Resource => p_Resource.Cas && p_Resource.GetContainedBundle() != null);
            else
                s_Variant = s_Resource.Variants.FirstOrDefault(p_Resource => p_Resource.GetContainedBundle() != null);

            if (s_Variant == null)
            {
                p_Writer.Write($"Could not find a valid variant of ({OrigName}).");
                return false;
            }

            var s_HasMeta = s_Variant.TryGetMeta(out var s_MetaBytes);
            var s_MetaHex = s_HasMeta && s_MetaBytes != null
                ? string.Concat(s_MetaBytes.Select(p_B => p_B.ToString("X2")))
                : "<none>";
            byte[]? s_MetaOverride = null;
            if (!string.IsNullOrWhiteSpace(MetaHex))
            {
                var s_Hex = MetaHex!.Replace(" ", "");
                s_MetaOverride = new byte[s_Hex.Length / 2];
                for (var s_I = 0; s_I < s_MetaOverride.Length; s_I++)
                    s_MetaOverride[s_I] = System.Convert.ToByte(s_Hex.Substring(s_I * 2, 2), 16);
                p_Writer.WriteLine($"  META OVERRIDE -> {MetaHex}");
            }

            p_Writer.WriteLine($"Adding '{NewName}' (type {s_Variant.GetResourceType()}, meta {s_MetaHex} from '{OrigName}') with {FilePath.Length} bytes from {FilePath.Name}.");

            s_BundleContext.AddResource(NewName!, new RenamedResource(s_Variant, FilePath.FullName, NewName!, s_MetaOverride));

            return true;
        }
    }
}
