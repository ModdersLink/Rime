using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Rime.Controls.Projects;
using Rime.Editor;
using Rime.Projects;
using Rime.Utils;
using RimeLib;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Serialization;
using RimeLib.Utils;

namespace Rime
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string BuildTitle => $"{GetType().Assembly.GetName().Name} - {GetType().Assembly.GetName().Version} {(m_Project != null ? $" - ({m_Project?.Name})" : string.Empty)}";

        public Logger Logger { get; protected set; }

        private Dictionary<Logger.LogLevel, Viewbox> m_LogImageMap = new Dictionary<Logger.LogLevel, Viewbox>
        {
            { Logger.LogLevel.Info, (Viewbox)Application.Current.Resources["ImgStatusInformationRequired"] },
            { Logger.LogLevel.Warn, (Viewbox)Application.Current.Resources["ImgStatusWarning"] },
            { Logger.LogLevel.Error, (Viewbox)Application.Current.Resources["ImgStatusError"] },
            { Logger.LogLevel.Debug, (Viewbox)Application.Current.Resources["ImgStatusRequiredOutline"] },
        };

        // Current active Project
        private RimeProject? m_Project = null;
        private string m_ProjectPath = string.Empty;
        private ulong m_TotalPartitionsToLoad = 0;
        private ulong m_TotalPartitionsLoaded = 0;

        public MainWindow()
        {
            InitializeComponent();

            // Create the logger and register the event handler
            Logger = new Logger(Logger.LogLevel.Debug);
            Logger.OnLogEntryAppended += OnLogEntryAppended;

            PartitionRegistry.OnPartitionRegistered += OnPartitionRegistered;

            Logger.WriteLog(Logger.LogLevel.Info, $"Rime starting, build: {BuildTitle}");

            Renderer.RendererStarted += OnRendererStarted;
        }

        private void OnPartitionRegistered(DatabasePartitionBase p_Partition)
        {
            Dispatcher.Invoke(() =>
            {
                m_TotalPartitionsLoaded++;

                if (m_TotalPartitionsToLoad == 0)
                    pbBar.Value = 0;
                else
                {
                    var s_Percentage = (double)m_TotalPartitionsLoaded / (double)m_TotalPartitionsToLoad;
                    pbBar.Value = s_Percentage * 100;
                }

                Logger.WriteLog(Logger.LogLevel.Info, $"Loaded partition {p_Partition.Name}");
            });
        }

        private void OnLogEntryAppended(object p_Sender, Logger.LogEntry p_Entry)
        {
            Dispatcher.Invoke(() =>
            {
                vbIcon.Child = m_LogImageMap[p_Entry.Level];
                tbStatus.Text = p_Entry.Message;
            });
        }

        private void OnRendererStarted(object? p_Sender, EventArgs p_E)
        {
            //var s_Browser = new ObjectBrowser();
            //s_Browser.Show();
            //MountAndSetup().Wait();
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

            /*if (!s_Mounter.TryGetResource("Systems/ShaderProgramDb", out var s_ShaderProgramDbRes))
                return;

            using var s_ShaderProgramDbReader = s_ShaderProgramDbRes.FirstVariant.GetReader();

            var s_ShaderProgramDbCtr = new ShaderProgramDatabaseContainer(s_ShaderProgramDbReader);
            
            if (!s_ShaderProgramDbCtr.TryGetDatabase(ShaderRenderPath.ShaderRenderPath_Dx11, out var s_ShaderProgramDb))
                return;

            if (!s_Mounter.TryGetResource("XP2/CommonTextures/MetalTile_01_M", out var s_TextureResource))
                return;

            var s_Converter = EngineInterfaceRegistry.Create<ITextureConverter>(EngineType.Frostbite2_0);
            var s_Texture = s_Converter.CreateTextureResourceView(s_TextureResource.FirstVariant, s_Mounter, Renderer.RenderManager.Device);

            Renderer.RenderManager.SetTexture(s_Texture);
            
            if (!s_Mounter.TryGetResource("xp2/objects/flowerpot_02/flowerpot_02_Mesh", out var s_MeshResource))
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
                .Shaders["XP2/Objects/FlowerPot_01/FlowerPot_01_Shader"];

            Renderer.RenderManager.DrawMesh(s_MeshSet, s_Shader, s_Mounter, s_ShaderProgramDb);*/
        }

        private void Window_Loaded(object p_Sender, RoutedEventArgs p_Event)
        {
            
        }

        private async void mmuNewProject_Click(object sender, RoutedEventArgs e)
        {
            // Show the project creation window
            var s_ProjectCreationDialog = new ProjectCreationWindow();
            if (s_ProjectCreationDialog.ShowDialog() != true)
                return;

            // Get the created project
            var s_Project = s_ProjectCreationDialog.CreatedProject;
            if (s_Project is null)
                return;

            // Get the json file path
            var s_ProjectPath = s_ProjectCreationDialog.CreatedProjectPath;

            Logger.WriteLog(Logger.LogLevel.Info, $"Project created - {s_Project.EngineVersion} at {s_Project.GameDirectory}");

            // Create a new mounter
            AssemblyUtils.LoadSupportAssembly(AssemblyType.Content, s_Project.EngineVersion);
            AssemblyUtils.LoadSupportAssembly(AssemblyType.Serialization, s_Project.EngineVersion);
            AssemblyUtils.LoadSupportAssembly(AssemblyType.Texture, s_Project.EngineVersion);

            s_Project.Mounter = EngineInterfaceRegistry.Create<IEngineMounter>(s_Project.EngineVersion);

            // Mount the game, without loading anything, should be faster
            await s_Project.Mounter.Mount(s_Project.GameDirectory, true, s_Project.EngineVersion);

            m_TotalPartitionsToLoad = (ulong)s_Project.Mounter.GetPartitions().Count;

            new MapEditor(s_Project.Mounter, Logger);

            m_Project = s_Project;
            m_ProjectPath = s_ProjectPath;
        }

        private bool Validate(string p_BuildInfoDllPath)
        {
            // Validate that our dll exists
            if (!File.Exists(p_BuildInfoDllPath))
            {
                MessageBox.Show($"File ({p_BuildInfoDllPath}) does not exist.", "File not found", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            // Get the dll directory
            var s_DllDirectory = Path.GetDirectoryName(p_BuildInfoDllPath);
            if (s_DllDirectory == null)
                return false;

            // Check for data directory
            if (!Directory.Exists(Path.Combine(s_DllDirectory, "Data")))
            {
                MessageBox.Show($"Data folder does not exist.", "Folder not found", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }
    }
}
