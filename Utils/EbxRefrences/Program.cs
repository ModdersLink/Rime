using CommandLine;
using RimeLib;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Serialization;
using RimeLib.Utils;

namespace EbxRefrences;

class Program
{
    internal class Options
    {

        [Value(0, MetaName = "gamePath", Required = true, HelpText = "The path of the game to be whose content you want to extract.")]
        public string GamePath { get; set; } = "";

        [Value(1, MetaName = "engineType", Required = true, HelpText = "The engine type of the game.")]
        public EngineType EngineType { get; set; }
    }

    static void Main(string[] p_Args)
    {
        Parser.Default.ParseArguments<Options>(p_Args).WithParsed(p_Options =>
        {
            if (!AssemblyUtils.LoadSupportAssembly(AssemblyType.Content, p_Options.EngineType) ||
                !AssemblyUtils.LoadSupportAssembly(AssemblyType.Serialization, p_Options.EngineType))
            {
                Console.WriteLine("Could not load support assemblies.");
                return;
            }
            
            DumpFiles(p_Options).Wait();
        }).WithNotParsed(p_Error =>
        {
            System.Environment.Exit(1);
        });
        
        Console.WriteLine("Hello World!");
    }
    
    private static async Task DumpFiles(Options p_Options)
    {
        var s_Mounter = EngineInterfaceRegistry.Create<IEngineMounter>(p_Options.EngineType);
        
        Console.WriteLine($"Mounting game with engine '{p_Options.EngineType}' at path '{p_Options.GamePath}'. Please wait, this could take a while.");

        await s_Mounter.Mount(p_Options.GamePath, true, s_Mounter.GetEngineType());
        PartitionRegistry.ParseAndRegisterAllPartitions(s_Mounter);

        // const string c_Name = "Levels/MP_001/Conquest";
        const string c_Name = "Levels/MP_Subway/MP_Subway/Settings_Win32";
        if (!s_Mounter.TryGetPartition(c_Name, out var s_SkeletonPartitionObj))
            return;

        var s_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(s_Mounter.GetEngineType());
        var s_SkeletonPartition = s_Converter.FromPartitionObject(c_Name, s_SkeletonPartitionObj.FirstVariant);


        var s_Builder = new InstanceTreeBuilder();
        s_Builder.ProcessPartition(s_SkeletonPartition);


        foreach (var s_Pair in s_Builder.PartitionGraph)
        {
            var s_PartitionInstanceNames = s_Pair.Value.Select(x =>
            {
                if (PartitionRegistry.TryGetPartition(x, out var s_XPart))
                    return s_XPart.Name;
                return x.ToString();
            });
            if (PartitionRegistry.TryGetPartition(s_Pair.Key, out var s_SrcPartition))
                Console.WriteLine(
                    $"{s_SrcPartition.Name} -> ({s_Pair.Value.Count}) [{string.Join(", ", s_PartitionInstanceNames)}]");
            else
                Console.WriteLine($"{s_Pair.Key} -> ({s_Pair.Value.Count}) [{string.Join(", ", s_PartitionInstanceNames)}]");
        }
    }
    
}
