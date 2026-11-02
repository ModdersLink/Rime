using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    /// <summary>
    /// Notes the shaders this bundle's content draws with, so a shader database built later in the
    /// same superbundle (the level's, in its main bundle) holds them too.
    /// </summary>
    [CommandDescription("Notes the shaders this bundle's content draws with, for a shader database built later in the superbundle.")]
    public class CollectDrawnShadersCommand : Command
    {
        [CommandArgument(Description = "The id of the mounted game.", Optional = true)]
        public int Id { get; set; } = 1;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_BundleContext = (BundleBuildingContext)p_Context;
            var s_SbContext = (SbBuildingContext)s_BundleContext.Parent!;
            var s_BaseContext = (BaseContext)s_SbContext.Parent!;
            if (!s_BaseContext.GetMounters().TryGetValue(Id, out var s_Mounter) || s_Mounter.GetEngineType() != s_SbContext.EngineType)
            {
                p_Writer.WriteLine($"Id ({Id}) is not a mounted game of this engine.");
                return false;
            }

            var s_Index = ShaderDatabaseIndex.Get(s_Mounter);
            var s_Shaders = DrawnShaders.Of(s_BundleContext, s_Mounter, s_Index.IsShader);
            var s_Before = s_SbContext.DrawnShaders.Count;
            s_SbContext.DrawnShaders.UnionWith(s_Shaders);
            p_Writer.WriteLine($"{s_Shaders.Count} shader(s) drawn by this bundle, {s_SbContext.DrawnShaders.Count - s_Before} not noted before.");
            return true;
        }
    }
}
