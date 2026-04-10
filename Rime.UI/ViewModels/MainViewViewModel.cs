using CommunityToolkit.Mvvm.ComponentModel;
using Dock.Model.Controls;
using Dock.Model.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rime.UI.ViewModels
{
    internal class MainViewViewModel : ObservableObject
    {
        public IRootDock? Layout
        {
            get => m_Layout;
            set => SetProperty(ref m_Layout, value);
        }

        public string CurrentStatus { get; set; }

        private readonly IFactory? m_Factory;
        private IRootDock? m_Layout;

        public MainViewViewModel()
        {
            // m_Factory = new DockFactory
        }
    }
}
