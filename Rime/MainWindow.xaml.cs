using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;
using fb;
using RimeLib;
using RimeLib.Content.Mounting;
using RimeLib.Extensions;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.Mesh.Frostbite;
using RimeLib.Mesh.Frostbite2_0;
using RimeLib.Shader.Frostbite2_0.Frostbite;
using RimeLib.Texture;
using RimeLib.Utils;

namespace Rime
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Renderer.RendererStarted += OnRendererStarted;
        }

        private void OnRendererStarted(object? p_Sender, EventArgs p_E)
        {
            MountAndSetup().Wait();
        }

        private async Task MountAndSetup()
        {
            AssemblyUtils.LoadSupportAssembly(AssemblyType.Content, EngineType.Frostbite2_0);
            AssemblyUtils.LoadSupportAssembly(AssemblyType.Serialization, EngineType.Frostbite2_0);
            AssemblyUtils.LoadSupportAssembly(AssemblyType.Texture, EngineType.Frostbite2_0);

            var s_Mounter = EngineInterfaceRegistry.Create<IEngineMounter>(EngineType.Frostbite2_0);

            await s_Mounter.Mount("B:\\Games\\Battlefield 3", false, EngineType.Frostbite2_0);
            await s_Mounter.MountSuperbundle("Win32/Chunks0", true);
            await s_Mounter.MountSuperbundle("Win32/Chunks1", true);
            await s_Mounter.MountSuperbundle("Win32/Chunks2", true);
            await s_Mounter.MountSuperbundle("Win32/MpChunks", true);
            await s_Mounter.MountSuperbundle("Win32/Xp2Chunks", true);
            await s_Mounter.MountSuperbundle("Win32/Levels/XP2_Skybar/XP2_Skybar", true);

            if (!s_Mounter.TryGetResource("weapons/xp2_knife_razorblade/knife_razorblade_d", out var s_TextureResource))
                return;

            var s_Converter = EngineInterfaceRegistry.Create<ITextureConverter>(EngineType.Frostbite2_0);
            var s_Texture = s_Converter.CreateTextureResourceView(s_TextureResource.FirstVariant, s_Mounter, Renderer.RenderManager.Device);

            Renderer.RenderManager.SetTexture(s_Texture);
            
            if (!s_Mounter.TryGetResource("xp2/objects/wallmodulesskybar/wallsskybar64_shelf_mesh", out var s_MeshResource))
                return;
            
            if (!s_Mounter.TryGetResource("levels/xp2_skybar/xp2_skybar/shaderdb", out var s_ShaderDbResource))
                return;

            using var s_ShaderReader = s_ShaderDbResource.FirstVariant.GetReader();
            var s_ShaderData = s_ShaderReader.ToArray();
            using var s_TempShaderReader = new RimeReader(new MemoryStream(s_ShaderData));
            var s_ShaderDb = new ShaderDatabaseContainer(s_TempShaderReader, s_Mounter);

            using var s_MeshReader = s_MeshResource.FirstVariant.GetReader();
            var s_MeshData = s_MeshReader.ToArray();
            using var s_TempMeshReader = new RimeReader(new MemoryStream(s_MeshData));
            var s_MeshSet = new MeshSetLayout(s_TempMeshReader);

            var s_Shader = s_ShaderDb.Databases[ShaderRenderPath.ShaderRenderPath_Dx11]
                .Shaders["XP2/Objects/WallModulesSkybar/Stone_01"];

            Renderer.RenderManager.DrawMesh(s_MeshSet, s_Shader, s_Mounter);
        }

        private void Window_Loaded(object p_Sender, RoutedEventArgs p_Event)
        {
            
        }
    }
}
