using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Shader;
using RimeLib.Utils;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Resolves shader texture dependencies and adds them to the bundle.")]
    public class ResolveShaderTexturesCommand : Command
    {
        [CommandArgument(Description = "The name of the shader resource.")]
        public string? Name { get; set; }

        [CommandArgument(Description = "Id returned by mount_game.")]
        public int Id { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                p_Writer.WriteLine("The specified shader resource could not be found.");
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
            if (!s_Mounters.TryGetValue(Id, out var s_EngineMounter) || s_EngineMounter == null)
            {
                p_Writer.WriteLine($"Id ({Id}) is not valid, ensure you mounted a game first");
                return false;
            }

            var s_EngineType = s_SbBuildingContext.EngineType;
            if (s_EngineMounter.GetEngineType() != s_EngineType)
            {
                p_Writer.WriteLine($"Cross-engine support has not been added, ({s_EngineMounter.GetEngineType()} != {s_EngineType})");
                return false;
            }

            if (!s_EngineMounter.TryGetResource(Name!, out var s_Resource))
            {
                p_Writer.WriteLine($"Could not find resource ({Name}).");
                return false;
            }

            var s_ResourceVariant = s_Resource.FirstVariant;
            if (s_BundleContext.Cas())
                s_ResourceVariant = s_Resource.Variants.FirstOrDefault(v => v.Cas && v.GetContainedBundle() != null) ?? s_ResourceVariant;

            if (s_ResourceVariant == null)
            {
                p_Writer.WriteLine($"Could not find a valid variant of ({Name}).");
                return false;
            }

            try
            {
                var s_Resolver = EngineInterfaceRegistry.Create<IShaderResolver>(s_EngineType);
                s_Resolver.Initialize(s_ResourceVariant, s_EngineMounter);
                var s_TextureNames = s_Resolver.GetTextureNames();

                foreach (var s_TextureName in s_TextureNames)
                {
                    if (s_EngineMounter.TryGetPartition(s_TextureName, out var s_Partition))
                    {
                        var s_PartitionVariant = s_Partition.FirstVariant;
                        if (s_BundleContext.Cas())
                            s_PartitionVariant = s_Partition.Variants.FirstOrDefault(v => v.Cas && v.GetContainedBundle() != null) ?? s_PartitionVariant;

                        if (s_PartitionVariant != null)
                        {
                            s_BundleContext.AddPartition(s_TextureName, s_PartitionVariant);
                            p_Writer.WriteLine($"Added partition: {s_TextureName}");
                        }
                        else
                        {
                            p_Writer.WriteLine($"Could not find a valid variant for texture partition: {s_TextureName}");
                        }
                    }
                    else
                    {
                        p_Writer.WriteLine($"Could not find texture partition: {s_TextureName}");
                    }
                }
            }
            catch (System.Exception s_Exception)
            {
                p_Writer.WriteLine($"Failed to resolve shader textures: {s_Exception.Message}");
                return false;
            }

            return true;
        }
    }
}
