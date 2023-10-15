using System;
using System.Collections.Generic;
using System.IO;
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


namespace Rime.Controls.Projects
{
    /// <summary>
    /// Interaction logic for ProjectCreationWindow.xaml
    /// </summary>
    public partial class ProjectCreationWindow : Window
    {
        public ProjectCreationWindow()
        {
            InitializeComponent();
        }

        private void btnCreateProject_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateGameDirectory(txtGameDirectory.Text))
            {
                txtGameDirectory.BorderBrush = Brushes.Red;
                return;
            }
            txtGameDirectory.BorderBrush = Brushes.Transparent;

            if (string.IsNullOrWhiteSpace(txtProjectFile.Text))
            {
                txtProjectFile.BorderBrush = Brushes.Red;
                return;
            }
            txtGameDirectory.BorderBrush = Brushes.Transparent;
        }

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
    }
}
