using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;
using RimeLib;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
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
            AssemblyUtils.LoadSupportAssembly(AssemblyType.Content, EngineType.Frostbite2_0);
            AssemblyUtils.LoadSupportAssembly(AssemblyType.Serialization, EngineType.Frostbite2_0);
            AssemblyUtils.LoadSupportAssembly(AssemblyType.Texture, EngineType.Frostbite2_0);

            var s_Mounter = EngineInterfaceRegistry.Create<IEngineMounter>(EngineType.Frostbite2_0);

            s_Mounter.Mount("B:\\Games\\Battlefield 3", true, EngineType.Frostbite2_0);

            if (!s_Mounter.TryGetResource(
                    "weapons/xp2_knife_razorblade/knife_razorblade_d",
                    out var s_Resource
                ))
                return;

            var s_Converter = EngineInterfaceRegistry.Create<ITextureConverter>(EngineType.Frostbite2_0);
            var s_Texture = s_Converter.CreateTextureResourceView(s_Resource.FirstVariant, s_Mounter, Renderer.RenderManager.Device);

            Renderer.RenderManager.SetTexture(s_Texture);
        }

        private void Window_Loaded(object p_Sender, RoutedEventArgs p_Event)
        {
            
        }
    }
}
