
using System;
using System.Threading.Tasks;
using CommandLine;
using RimeLib;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Serialization;
using RimeLib.Utils;

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
        // AssemblyUtils.LoadBindingAssembly(EngineType.Frostbite2024_1, "Battlefield6");
        AssemblyUtils.LoadBindingAssembly(EngineType.Frostbite2013_2, "Warsaw");
        var s_Mounter = EngineInterfaceRegistry.Create<IEngineMounter>(p_Options.EngineType);
        
        Console.WriteLine($"Mounting game with engine '{p_Options.EngineType}' at path '{p_Options.GamePath}'. Please wait, this could take a while.");

        await s_Mounter.Mount(p_Options.GamePath, false, s_Mounter.GetEngineType());
        await s_Mounter.MountSuperbundle("Win32/Globals", true);
        await s_Mounter.MountSuperbundle("Win32/FrontEndChunks", true);
        await s_Mounter.MountSuperbundle("win32/levels/frontend/frontend", true);
        PartitionRegistry.ParseAndRegisterAllPartitions(s_Mounter);

        // const string c_Name = "common/hardware/gadgets/launchers/stinger/art/skins/gsr0001/spo_stinger_gsr0001";
        // // const string c_Name = "common/characters/mp/customization/cosmetics/spo/spo_egy_desert";
        // if (!s_Mounter.TryGetPartition(c_Name, out var s_SkeletonPartitionObj))
        //     return;
        // {
        //     using var s_Reader = s_SkeletonPartitionObj.FirstVariant.GetReader();
        //     var s_Data = s_Reader.ReadBytes((int) s_Reader.Length);
        //     File.WriteAllBytes(@"/home/txt/Documents/RE/frostbite/bf6/release_2025_10/ebx_test.ebx_riff", s_Data);
        // }
        //
        // var s_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(s_Mounter.GetEngineType());
        // var s_SkeletonPartition = s_Converter.FromPartitionObject(c_Name, s_SkeletonPartitionObj.FirstVariant);

        var s_PartitionRegistry = PartitionRegistry.Partitions;
        
    }
    
}
