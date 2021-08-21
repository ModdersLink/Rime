using RimeLib.Frostbite.Containers;
using RimeLib.UI.Controls.Meta;
using RimeLib.UI.ViewModels.fb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RimeLib.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Current build string
        /// </summary>
        public string BuildString => $"RimeLib.UI Pre-Beta [Build: {GetType().Assembly.GetName().Version}]";

        public MainWindow()
        {
            InitializeComponent();

            dockingManager.DocumentsSource = new[] 
            {
                new Vec2ViewModel
                {
                    Value = new Vec2(1337, 1338)
                },
                new Vec2ViewModel
                {
                    Value = new Vec2(1337, 1338)
                },
                new Vec2ViewModel
                {
                    Value = new Vec2(1337, 1338)
                },
                new Vec2ViewModel
                {
                    Value = new Vec2(1337, 1338)
                }
            };
        }
    }
}
