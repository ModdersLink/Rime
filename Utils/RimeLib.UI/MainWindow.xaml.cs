using System;
using System.Windows;

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

            // TODO: Fix code below
            throw new NotImplementedException();
            //dockingManager.DocumentsSource = new[]
            //{

            //    new Vec2ViewModel
            //    {
            //        Value = new Vec2(1337, 1338)
            //    },
            //    new Vec2ViewModel
            //    {
            //        Value = new Vec2(1337, 1338)
            //    },
            //    new Vec2ViewModel
            //    {
            //        Value = new Vec2(1337, 1338)
            //    },
            //    new Vec2ViewModel
            //    {
            //        Value = new Vec2(1337, 1338)
            //    }
            //};
        }
    }
}
