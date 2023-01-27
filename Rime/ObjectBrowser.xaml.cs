using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Utils;
using RimeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using RimeLib.Content.Frostbite;
using RimeLib.Serialization;
using MeshVariationDatabase = fb.MeshVariationDatabase;

namespace Rime
{
    class ObjectItem
    {
        public string Name { get; set; }
        public string? Bundle { get; set; }
        public string? Superbundle { get; set; }
        public uint Variation { get; set; }
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

                    s_Resources.Add(new ObjectItem()
                    {
                        Name = s_MeshAsset.Name,
                        Bundle = s_MeshVariationDb.Partition?.AssociatedVariant?.GetContainedBundle(),
                        Superbundle = s_MeshVariationDb.Partition?.AssociatedVariant?.GetContainedSuperbundle(),
                        Variation = s_MeshVariation.VariationAssetNameHash,
                    });
                }
            }
            
            objectList.ItemsSource = s_Resources;
        }
    }
}
