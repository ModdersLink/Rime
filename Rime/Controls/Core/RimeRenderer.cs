using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Threading;
using Application = System.Windows.Application;
using KeyEventArgs = System.Windows.Input.KeyEventArgs;
using Size = System.Drawing.Size;
using UserControl = System.Windows.Forms.UserControl;

namespace Rime.Controls.Core
{
    public class RimeRenderer : ContentPresenter
    {
        private class RimeRenderHost : WindowsFormsHost
        {
            private readonly RimeRenderManager m_RenderManager = new();
            private DispatcherOperation? m_ResizeOperation;

            public RimeRenderHost()
            {
                Child = new UserControl();

                Loaded += OnLoaded;
                Unloaded += OnUnloaded;

                Child.KeyPress += OnKeyPress;
            }

            private void OnKeyPress(object? p_Sender, KeyPressEventArgs p_Event)
            {
                m_RenderManager?.OnInputChar(p_Event.KeyChar);
            }

            private void OnLoaded(object p_Sender, RoutedEventArgs p_E)
            {
                var s_MainWindowHandle = new WindowInteropHelper(Application.Current.MainWindow).Handle;
                m_RenderManager.InitializeGraphics(Child.Handle, s_MainWindowHandle, GetSize());

                CompositionTarget.Rendering += OnRender;
            }

            private void OnUnloaded(object p_Sender, RoutedEventArgs p_E)
            {
                CompositionTarget.Rendering -= OnRender;
                m_RenderManager.Cleanup();
            }

            private void OnRender(object? p_Sender, EventArgs p_E)
            {
                m_RenderManager.DrawFrame(true);
            }

            protected override void OnRenderSizeChanged(SizeChangedInfo p_SizeInfo)
            {
                if (m_ResizeOperation?.Status == DispatcherOperationStatus.Pending)
                    m_ResizeOperation.Abort();

                m_ResizeOperation = Dispatcher.BeginInvoke(
                    DispatcherPriority.Background,
                    () =>
                    {
                        if (!IsLoaded)
                            return;

                        m_RenderManager.ResizeView(GetSize());
                    }
                );
            }

            private Size GetSize()
            {
                var s_Width = (int)ActualWidth;
                var s_Height = (int)ActualHeight;

                if (s_Width <= 0)
                    s_Width = 1;

                if (s_Height <= 0)
                    s_Height = 1;

                return new Size(s_Width, s_Height);
            }
        }

        public RimeRenderer()
        {
            Content = new RimeRenderHost();
        }
    }
}