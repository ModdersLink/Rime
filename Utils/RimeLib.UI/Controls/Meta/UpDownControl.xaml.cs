using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RimeLib.UI.Controls.Meta
{
    /// <summary>
    /// Interaction logic for UpDownControl.xaml
    /// </summary>
    public partial class UpDownControl : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        public float Value { get; set; } = 0.0f;

        public UpDownControl()
        {
            InitializeComponent();
        }
    }
}
