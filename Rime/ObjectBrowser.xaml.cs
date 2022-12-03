using System;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Utils;
using RimeLib;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using fb;
using RimeLib.Content.Frostbite;
using RimeLib.Serialization;
using RimeLib.Shader.Frostbite2_0.Frostbite;
using MeshVariationDatabase = fb.MeshVariationDatabase;
using SharpGLTF.Schema2;
using RimeLib.IO;
using System.IO;
using RimeLib.Extensions;
using RimeLib.Mesh.Frostbite;

namespace Rime
{
    class ObjectItem
    {
        public string Name { get; set; }
        public string? Bundle { get; set; }
        public string? Superbundle { get; set; }
        public uint Variation { get; set; }
        public string Materials { get; set; }

        public MeshVariationDatabaseEntry m_Variation;
    }

    /// <summary>
    /// Interaction logic for ObjectBrowser.xaml
    /// </summary>
    public partial class ObjectBrowser : Window
    {
        public ObjectBrowser()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MountAndSetup().Wait();
        }


        private async Task MountAndSetup()
        {
            AssemblyUtils.LoadSupportAssembly(AssemblyType.Content, EngineType.Frostbite2_0);
            AssemblyUtils.LoadSupportAssembly(AssemblyType.Serialization, EngineType.Frostbite2_0);
            AssemblyUtils.LoadSupportAssembly(AssemblyType.Texture, EngineType.Frostbite2_0);

            var s_Mounter = EngineInterfaceRegistry.Create<IEngineMounter>(EngineType.Frostbite2_0);

            await s_Mounter.Mount("C:\\Games\\Battlefield 3", false, EngineType.Frostbite2_0);
            await s_Mounter.MountSuperbundle("Win32/Globals", true);
            await s_Mounter.MountSuperbundle("Win32/Chunks0", true);
            await s_Mounter.MountSuperbundle("Win32/Chunks1", true);
            await s_Mounter.MountSuperbundle("Win32/Chunks2", true);
            await s_Mounter.MountSuperbundle("Win32/MpChunks", true);
            await s_Mounter.MountSuperbundle("Win32/Xp2Chunks", true);
            await s_Mounter.MountSuperbundle("Win32/Levels/XP2_Skybar/XP2_Skybar", true);

            foreach (var (s_Name, s_ResourceObj) in s_Mounter.GetResources())
            {
                if (s_ResourceObj.FirstVariant.GetResourceType() != ResourceType.IShaderDatabase)
                    continue;

                using var s_ShaderReader = s_ResourceObj.FirstVariant.GetReader();
                var s_ShaderData = s_ShaderReader.ToArray();
                using var s_TempShaderReader = new RimeReader(new MemoryStream(s_ShaderData));
                var s_ShaderDb = new ShaderDatabaseContainer(s_TempShaderReader, s_Mounter);

                var s_Path = s_ShaderDb.Databases[ShaderRenderPath.ShaderRenderPath_Dx11];

                foreach (var (s_ShaderName, s_Info) in s_Path.Shaders)
                {
                    Debug.WriteLine($"Found shader '{s_ShaderName}' in '{s_Name}' with '{s_Info.Solutions.Length}' solutions.");
                }
            }

            var s_Resources = new List<ObjectItem>();

            PartitionRegistry.ParseAndRegisterAllPartitions(s_Mounter);

            foreach (var s_Partition in PartitionRegistry.Partitions)
            {
                if (s_Partition.PrimaryInstance is not MeshVariationDatabase s_MeshVariationDb)
                    continue;

                foreach (var s_MeshVariationRef in s_MeshVariationDb.Entries)
                {
                    var s_MeshVariation = s_MeshVariationRef.Get();

                    if (s_MeshVariation == null)
                        continue;

                    var s_MeshAsset = s_MeshVariation.Mesh.Get();

                    if (s_MeshAsset == null)
                        continue;

                    if (!s_Mounter.TryGetResource(s_MeshAsset.Name, out var s_MeshResource))
                        continue;

                    using var s_MeshReader = s_MeshResource.FirstVariant.GetReader();
                    var s_MeshData = s_MeshReader.ToArray();
                    using var s_TempMeshReader = new RimeReader(new MemoryStream(s_MeshData));
                    var s_MeshSet = new MeshSetLayout(s_TempMeshReader);

                    var s_Lod0 = s_MeshSet.Lods[0].Object;

                   

                    s_Resources.Add(new ObjectItem()
                    {
                        Name = s_MeshAsset.Name,
                        Bundle = s_MeshVariationDb.Partition?.AssociatedVariant?.GetContainedBundle(),
                        Superbundle = s_MeshVariationDb.Partition?.AssociatedVariant?.GetContainedSuperbundle(),
                        Variation = s_MeshVariation.VariationAssetNameHash,
                        m_Variation = s_MeshVariation,
                        Materials = String.Join(" | ", s_Lod0.Subsets.Get.Select(x => x.MaterialName.Object)),
                    });

                    if (!s_MeshVariation.Materials.Any())
                        throw new Exception("COCK");
                }
            }
            
            objectList.ItemsSource = s_Resources;
        }

        private void MenuItem_OnClick(object p_Sender, RoutedEventArgs p_E)
        {
            foreach (var s_Item in objectList.SelectedItems)
            {
                var s_ObjectItem = s_Item as ObjectItem;

                if (s_ObjectItem == null)
                    continue;


            }
        }
    }
}
