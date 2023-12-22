using Microsoft.Win32;
using Rime.Projects;
using RimeLib.Frostbite;
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Media;


namespace Rime.Controls.Projects
{
    /// <summary>
    /// Interaction logic for ProjectCreationWindow.xaml
    /// </summary>
    public partial class ProjectCreationWindow : Window
    {
        public RimeProject? CreatedProject { get; protected set; } = null;

        public string CreatedProjectPath { get; protected set; } = string.Empty;

        /// <summary>
        /// Initial constructor
        /// </summary>
        public ProjectCreationWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Callback for creation of a new project
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Arguments</param>
        private void btnCreateProject_Click(object sender, RoutedEventArgs e)
        {
            // Validate the game directory
            if (!ValidateGameDirectory(txtGameDirectory.Text))
            {
                txtGameDirectory.BorderBrush = Brushes.Red;
                return;
            }
            txtGameDirectory.BorderBrush = Brushes.Transparent;

            // Validate the output project directory
            if (string.IsNullOrWhiteSpace(txtProjectFile.Text))
            {
                txtProjectFile.BorderBrush = Brushes.Red;
                return;
            }
            txtProjectFile.BorderBrush = Brushes.Transparent;

            CreatedProjectPath = txtProjectFile.Text;

            CreatedProject = new RimeProject
            {
                GameDirectory = txtGameDirectory.Text,
                EngineVersion = (EngineType)cbEngineType.SelectedItem,
            };

            File.WriteAllText(CreatedProjectPath, JsonSerializer.Serialize(CreatedProject, new JsonSerializerOptions
            {
                WriteIndented = true,
            }));

            DialogResult = true;
            Close();
        }

        /// <summary>
        /// Validates the game directory, this currently just checks for the /Data folder
        /// but in the future can do more
        /// </summary>
        /// <param name="p_DirectoryPath">Selected game directory path</param>
        /// <returns>True on success, false otherwise</returns>
        private bool ValidateGameDirectory(string p_DirectoryPath)
        {
            // Validate the game directory text
            if (string.IsNullOrWhiteSpace(p_DirectoryPath))
                return false;

            // TODO: Check to see if there's a build info dll

            // Validate that the game data directory exists
            var s_DirectoryPath = Path.Combine(p_DirectoryPath, "Data");
            if (!Directory.Exists(s_DirectoryPath))
                return false;


            return true;
        }

        /// <summary>
        /// Callback for saving a project path
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Arguments</param>
        private void btnSelectProjectFile_Clicked(object sender, RoutedEventArgs e)
        {
            // Create a new save file dialog
            var s_FileSaveDialog = new SaveFileDialog
            {
                CheckFileExists = false,
                Title = "Save Rime project...",
                Filter = "Rime Project (*.json)|*.json",
            };

            // See if the dialog was successful
            if (s_FileSaveDialog.ShowDialog() == true)
                txtProjectFile.Text = s_FileSaveDialog.FileName;
        }

        private void btnSelectGameDirectory_Click(object sender, RoutedEventArgs e)
        {
            var s_FileSelectDialog = new OpenFileDialog
            {
                CheckFileExists = true,
                Title = "Select game executable",
                Filter = "Game Executable (*.exe)|*.exe",
                Multiselect = false
            };

            if (s_FileSelectDialog.ShowDialog() != true)
                return;

            var s_SelectedFile = s_FileSelectDialog.FileName;

            txtGameDirectory.Text = Path.GetDirectoryName(s_SelectedFile);
        }
    }
}
