using CommandLine;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using RimeLib;
using RimeLib.Ant.Frostbite2_0.Frostbite;
using RimeLib.Ant.EA.Readers;
using RimeLib.Serialization.Frostbite2_0.Ebx;
using RimeLib.Serialization;
using fb;
using RimeLib.Ant.EA.Compression.DCT;
using ant;
using RimeLib.Ant.EA.Types;
using RimeLib.Ant.Frostbite2_0.EA.Compression.DCT;

namespace TextureExtractor
{
    class Program
    {
        public class Options
        {
            [Option("sb", Required = false, Separator = ',', HelpText = "The superbundles to be mounted. When not specified, all available superbundles are mounted.")]
            public IEnumerable<string> MountSuperbundles { get; set; } = new string[0];

            [Option("bundles", Required = false, Separator = ',', HelpText = "The bundles to be mounted. When not specified, all available bundles are mounted.")]
            public IEnumerable<string> MountBundles { get; set; } = new string[0];

            [Option('q', "quiet", Required = false, Default = false, HelpText = "Suppress console output.")]
            public bool Quiet { get; set; } = false;


            [Value(0, MetaName = "gamePath", Required = true, HelpText = "The path of the game to be whose content you want to extract.")]
            public string GamePath { get; set; } = "";

            [Value(1, MetaName = "engineType", Required = true, HelpText = "The engine type of the game.")]

            public EngineType EngineType
            {
                get; set;
            }

        }


        static void Main(string[] p_Args)
        {
            Parser.Default.ParseArguments<Options>(p_Args).WithParsed(p_Options =>
            {
                LoadEngineAssemblies(p_Options);
                LoadGame(p_Options);

                Console.WriteLine("Textures successfully extracted. Press any key to exit...");
                Console.ReadKey();
            }).WithNotParsed(p_Err => { Environment.Exit(1); });
        }

        private static void LoadEngineAssemblies(Options p_Options)
        {
            void Load(string p_Assembly)
            {
                try
                {
                    Assembly.Load(p_Assembly);
                }
                catch
                {
                    if (!p_Options.Quiet)
                        Console.WriteLine($"Failed to load supporting engine assembly ({p_Assembly}.dll). This means that the engine is not supported or that you are missing required files.");

                    Environment.Exit(1);
                }
            }


            if (!p_Options.Quiet)
                Console.WriteLine("Loading engine support assemblies.");

            Load("RimeLib.Content." + p_Options.EngineType);
            Load("RimeLib.Ant." + p_Options.EngineType);
        }

        private static async void LoadGame(Options p_Options)
        {
            var s_Mounter = EngineInterfaceRegistry.Create<IEngineMounter>(p_Options.EngineType);

            var s_MountSuperbundles = p_Options.MountSuperbundles.ToList();
            var s_MountBundles = p_Options.MountBundles.ToList();

            // Only auto-mount when a user has not specified any specific superbundles or bundles.
            if (!p_Options.Quiet)
                Console.WriteLine($"Mounting game with engine '{p_Options.EngineType}' at path '{p_Options.GamePath}'. Please wait, this could take a while.");

            await s_Mounter.Mount(p_Options.GamePath, s_MountSuperbundles.Count == 0 && s_MountBundles.Count == 0, p_Options.EngineType);

            // Mount the requested superbundles.
            if (s_MountSuperbundles.Count > 0)
            {
                if (!p_Options.Quiet)
                    Console.WriteLine($"Mounting requested superbundles. Please wait, this could take a while.");

                var s_AutoMountBundles = s_MountBundles.Count == 0;
                var s_SbTasks = s_MountSuperbundles.Select(p_Sb => s_Mounter.MountSuperbundle(p_Sb, s_AutoMountBundles));
                await Task.WhenAll(s_SbTasks);
            }

            // Mount all the requested bundles.
            if (s_MountBundles.Count > 0)
            {
                if (!p_Options.Quiet)
                    Console.WriteLine($"Mounting requested bundles. Please wait, this could take a while.");

                var s_BundleTasks = s_MountBundles.Select(s_Mounter.MountBundle);
                await Task.WhenAll(s_BundleTasks);
            }

            // Dump everything!
            if (!p_Options.Quiet)
                Console.WriteLine($"Everything is now mounted! Starting content extraction.");

            DumpAssetBankReflections(s_Mounter);


            return;
            
            LoadAntPackageAsset(s_Mounter, "animations/antanimations/s_basicassets");

            LoadAntPackageAsset(s_Mounter, "animations/antanimations/ak74", true);
            //LoadAntPackageAsset(s_Mounter, "animations/antanimations/m4a1", true);

            return;

            object s_LockObject = new();

            
            var s_Resources = s_Mounter.GetResources();
            Parallel.ForEach(s_Resources, (p_Pair) =>
            {
                var s_Name = p_Pair.Key;
                var s_Resource = p_Pair.Value;

                if (s_Resource.FirstVariant.GetResourceType() != ResourceType.AssetBank)
                    return;

                lock (s_LockObject)
                {
                    DumpAssetBankResource(s_Mounter, s_Name);
                }
            });


            return;
            
            Parallel.ForEach(s_Mounter.GetPartitions(), p_PartitionPair =>
            {
                if (!p_PartitionPair.Key.ToLower().StartsWith("animations/antanimations/"))
                    return;


                lock (s_LockObject)
                {

                    var s_Reader = new EbxReader();

                    var s_Partition = s_Reader.ParsePartition(p_PartitionPair.Key, p_PartitionPair.Value.FirstVariant);
                    if (s_Partition == null)
                        return;

                    //PartitionRegistry.RegisterPartition(s_Partition);

                    if (s_Partition.PrimaryInstanceCtr.TypeName != "AntPackageAsset")
                        return;

                    var s_AntPackage = s_Partition.PrimaryInstance as AntPackageAsset;

                    if (s_AntPackage == null)
                        return;


                    if (!s_Mounter.TryGetChunk(s_AntPackage.StreamingGuid, out var s_Chunk))
                        return;

                    var s_RawReader = s_Chunk.FirstVariant.GetReader();
                    var s_Data = s_RawReader.ReadBytes((int)s_RawReader.Length);

                    using var s_DataReader = new RimeReader(new MemoryStream(s_Data));

                    var s_Bank = new AssetBank();
                    s_Bank.Load(s_DataReader);

                }
            });
            
            //RefrenceTypeRegistry.Instance.Save(@"F:\bf3\");
        }


        private static void DumpAssetBankReflections(IEngineMounter p_Mounter)
        {
            List<ReflectionAssetBank> s_Banks = new();
            
            object s_LockObject = new();
            
            /*
            var s_Resources = p_Mounter.GetResources();
            Parallel.ForEach(s_Resources, (p_Pair) =>
            {
                var s_Name = p_Pair.Key;
                var s_Resource = p_Pair.Value;

                if (s_Resource.FirstVariant.GetResourceType() != ResourceType.AssetBank)
                    return;

                lock (s_LockObject)
                {
                    var s_RawReader = s_Resource.FirstVariant.GetReader();

                    var s_Data = s_RawReader.ReadBytes((int)s_RawReader.Length);


                    Console.WriteLine(s_Name);

                    using var s_Reader = new RimeReader(new MemoryStream(s_Data));

                    var s_Bank = new ReflectionAssetBank();
                    s_Bank.Load(s_Reader);

                    s_Banks.Add(s_Bank);
                }
            });
            */


            Parallel.ForEach(p_Mounter.GetPartitions(), p_PartitionPair =>
            {
                if (!p_PartitionPair.Key.ToLower().StartsWith("animations/antanimations/"))
                    return;


                lock (s_LockObject)
                {

                    var s_Reader = new EbxReader();

                    var s_Partition = s_Reader.ParsePartition(p_PartitionPair.Key, p_PartitionPair.Value.FirstVariant);
                    if (s_Partition == null)
                        return;

                    //PartitionRegistry.RegisterPartition(s_Partition);

                    if (s_Partition.PrimaryInstanceCtr.TypeName != "AntPackageAsset")
                        return;

                    var s_AntPackage = s_Partition.PrimaryInstance as AntPackageAsset;

                    if (s_AntPackage == null)
                        return;



                    if (p_Mounter.TryGetResource(s_AntPackage.Name.ToLower(), out var s_BundleObject))
                    {

                        var s_BundleRawReader = s_BundleObject.FirstVariant.GetReader();
                        var s_BundleData = s_BundleRawReader.ReadBytes((int)s_BundleRawReader.Length);

                        using var s_BundleDataReader = new RimeReader(new MemoryStream(s_BundleData));

                        var s_BundleBank = new ReflectionAssetBank();
                        s_BundleBank.Load(s_BundleDataReader);
            
                        
                        s_Banks.Add(s_BundleBank);
                    }


                    if (p_Mounter.TryGetChunk(s_AntPackage.StreamingGuid, out var s_Chunk))
                    {
                        var s_ResourceRawReader = s_Chunk.FirstVariant.GetReader();
                        var s_ResourceData = s_ResourceRawReader.ReadBytes((int)s_ResourceRawReader.Length);

                        using var s_ResourceDataReader = new RimeReader(new MemoryStream(s_ResourceData));

                        var s_ResourceBank = new ReflectionAssetBank();
                        s_ResourceBank.Load(s_ResourceDataReader);
                        
                        
                        s_Banks.Add(s_ResourceBank);
                    }

                }
            });


            foreach (var s_Bank in s_Banks)
            {
                foreach (var s_GuidRefProp in s_Bank.IdRefFields)
                {
                    if (s_GuidRefProp.m_Instance == null)
                        continue; 
                    if (s_GuidRefProp.m_Field == null)
                        continue; 
                    if (s_GuidRefProp.m_Guid == null)
                        continue; 
                    
                    var s_SolvedRef = s_GuidRefProp.m_Resolver?.ResolveObject(s_GuidRefProp.m_Guid);

                    if (s_SolvedRef == null)
                        continue;
                    
                    var s_Key = $"{s_GuidRefProp.m_Field.DeclaringType.Name}.{s_GuidRefProp.m_Field.Name}";
                    
                    //Console.WriteLine($"{s_Key} = {s_SolvedRef.GetType().Name}");
                    RefrenceTypeRegistry.Instance.AddGuidRef(s_Key, s_SolvedRef.GetType().Name);
                    //s_GuidRefs.Add(s_Key, s_SolvedRef.GetType().Name);
                    
                }
                
                foreach (var s_DataRefProp in s_Bank.DataRefFields)
                {
                    if (s_DataRefProp.m_Field == null)
                        continue; 
                    if (s_DataRefProp.m_Target == null)
                        continue; 
                    
                    var s_Key = $"{s_DataRefProp.m_Field .DeclaringType.Name}.{s_DataRefProp.m_Field .Name}";
                    
                    //Console.WriteLine($"{s_Key} = {s_DataRef.GetType().Name}");
                    RefrenceTypeRegistry.Instance.AddDataRef(s_Key, s_DataRefProp.m_Target.GetType().Name);
                    //s_GuidRefs.Add(s_Key, s_SolvedRef.GetType().Name);
                    
                }
                
                foreach (var s_BasePair in s_Bank.BaseClasses)
                {
                    RefrenceTypeRegistry.Instance.AddBase(s_BasePair.Key, s_BasePair.Value);
                }
            }
            
            
            
            RefrenceTypeRegistry.Instance.Save(@"/home/txt/Documents/RE/frostbite/bf3/ant");
        }
        
        public static void DumpAssetBankResource(IEngineMounter p_Mounter, string p_Path) // "animations/characters/sp/sp_paris/tradingfloor/tradingfloorwires_animset"
        {
            if (!p_Mounter.TryGetResource(p_Path, out var s_Resource))
                return;


            var s_RawReader = s_Resource.FirstVariant.GetReader();

            var s_Data = s_RawReader.ReadBytes((int)s_RawReader.Length);

            if (false)
            {
                var s_SavePath = Path.Combine(@"F:\bf3\assetbank\", s_Resource.OriginalName);

                var s_DirectoryPath = Path.GetDirectoryName(s_SavePath)!;

                if (!Directory.Exists(s_DirectoryPath))
                    Directory.CreateDirectory(s_DirectoryPath!);

                File.WriteAllBytes(s_SavePath, s_Data);
            }

            Console.WriteLine(p_Path);

            using var s_Reader = new RimeReader(new MemoryStream(s_Data));

            var s_Bank = new AssetBank();
           s_Bank.Load(s_Reader);


            var s_DctAnims = s_Bank.Objects.Where(x => x is DctAnimationAsset).Select(x => x as DctAnimationAsset).ToList();


            foreach( var s_Dct in s_DctAnims)
            {
                var s_Decompressor = new Decompressor();

                s_Decompressor.Parse(s_Dct);
            }

            //Console.WriteLine(s_Reader.Position);
        }

        public static void LoadAntPackageAsset(IEngineMounter p_Mounter, string p_Path, bool p_Process = false)
        {
            if (!p_Mounter.TryGetPartition(p_Path, out var s_PartitionObject))
                return;


            var s_Reader = new EbxReader();

            var s_Partition = s_Reader.ParsePartition(p_Path, s_PartitionObject.FirstVariant);
            if (s_Partition == null)
                return;

            if (s_Partition.PrimaryInstanceCtr.TypeName != "AntPackageAsset")
                return;

            var s_AntPackage = s_Partition.PrimaryInstance as AntPackageAsset;

            if (s_AntPackage == null)
                return;


            AssetBank? s_BundleBank = null;

            if (p_Mounter.TryGetResource(s_AntPackage.Name.ToLower(), out var s_BundleObject))
            {

                var s_BundleRawReader = s_BundleObject.FirstVariant.GetReader();
                var s_BundleData = s_BundleRawReader.ReadBytes((int)s_BundleRawReader.Length);

                using var s_BundleDataReader = new RimeReader(new MemoryStream(s_BundleData));

                s_BundleBank = new AssetBank();
                s_BundleBank.Load(s_BundleDataReader);


                
            }

            var s_BundleClips = s_BundleBank?.Objects.Where(x => x is ClipControllerAsset).Select(x => x as ClipControllerAsset).ToList();



            if (p_Mounter.TryGetChunk(s_AntPackage.StreamingGuid, out var s_Chunk))
            {
                var s_ResourceRawReader = s_Chunk.FirstVariant.GetReader();
                var s_ResourceData = s_ResourceRawReader.ReadBytes((int)s_ResourceRawReader.Length);

                using var s_ResourceDataReader = new RimeReader(new MemoryStream(s_ResourceData));

                var s_ResourceBank = new AssetBank();
                s_ResourceBank.Load(s_ResourceDataReader);


                if (p_Process)
                {
                    var s_Clips = s_ResourceBank.Objects.Where(x => x is ClipControllerAsset).Select(x => x as ClipControllerAsset).ToList();


                    var s_DctAnims = s_ResourceBank.Objects.Where(x => x is DctAnimationAsset).Select(x => x as DctAnimationAsset).ToList();

                    foreach (var s_Dct in s_DctAnims)
                    {
                        if (s_Dct.ObjectName != "ReloadClipEmpty Anim")
                        //if (s_Dct.Name != "ReloadClipFull Anim")
                            continue;

                        Console.WriteLine(s_Dct.ObjectName);

                        var s_Decompressor = new Decompressor();

                        s_Decompressor.Parse(s_Dct);
                    }
                }
            }

        }

    }
}
