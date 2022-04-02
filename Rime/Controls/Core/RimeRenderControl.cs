using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using Size = System.Drawing.Size;

namespace Rime.Controls.Core
{
    /// <summary>
    /// Creates internal Hwnd to host DirectXComponent within a control in the window.
    /// </summary>
    public class RimeRenderControl : HwndHost
    {
        private class Native
        {
            public const int WS_CHILD = 0x40000000;
            public const int WS_VISIBLE = 0x10000000;

            public const int IDC_ARROW = 32512;

            [StructLayout(LayoutKind.Sequential)]
            public struct WndClassEx
            {
                public uint cbSize;
                public uint style;
                [MarshalAs(UnmanagedType.FunctionPtr)]
                public WndProc lpfnWndProc;
                public int cbClsExtra;
                public int cbWndExtra;
                public IntPtr hInstance;
                public IntPtr hIcon;
                public IntPtr hCursor;
                public IntPtr hbrBackground;
                public string lpszMenuName;
                public string lpszClassName;
                public IntPtr hIconSm;
            }

            [DllImport("user32.dll")]
            public static extern IntPtr DefWindowProc(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam);

            public delegate IntPtr WndProc(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

            [DllImport("user32.dll", EntryPoint = "CreateWindowEx", CharSet = CharSet.Auto)]
            public static extern IntPtr CreateWindowEx(
                int exStyle,
                string className,
                string windowName,
                int style,
                int x, int y,
                int width, int height,
                IntPtr hwndParent,
                IntPtr hMenu,
                IntPtr hInstance,
                [MarshalAs(UnmanagedType.AsAny)] object pvParam);

            [DllImport("user32.dll", EntryPoint = "DestroyWindow", CharSet = CharSet.Auto)]
            public static extern bool DestroyWindow(IntPtr hwnd);

            [DllImport("kernel32.dll")]
            public static extern IntPtr GetModuleHandle(string? module);

            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.U2)]
            public static extern short RegisterClassEx([In] ref WndClassEx lpwcx);

            [DllImport("user32.dll")]
            public static extern IntPtr LoadCursor(IntPtr hInstance, int lpCursorName);
        }

        private IntPtr m_Hwnd = IntPtr.Zero;
        private bool m_Initialized;

        private readonly RimeRenderManager m_RenderManager;

        public RimeRenderControl()
        {
            m_RenderManager = new RimeRenderManager();

            Loaded += OnLoaded;
            Unloaded += OnUnloaded;
        }

        private void OnLoaded(object p_Sender, RoutedEventArgs p_Event)
        {
            CompositionTarget.Rendering += OnDraw;
        }

        private void OnUnloaded(object p_Sender, RoutedEventArgs p_Event)
        {
            CompositionTarget.Rendering -= OnDraw;
        }

        private void OnDraw(object? p_Sender, EventArgs p_Event)
        {
            if (m_Initialized)
                m_RenderManager.DrawFrame(true);
        }

        protected override HandleRef BuildWindowCore(HandleRef p_HwndParent)
        {
            var s_WndClass = new Native.WndClassEx();
            s_WndClass.cbSize = (uint)Marshal.SizeOf(s_WndClass);
            s_WndClass.hInstance = Native.GetModuleHandle(null);
            s_WndClass.lpfnWndProc = Native.DefWindowProc;
            s_WndClass.lpszClassName = "RimeRenderer";
            s_WndClass.hCursor = Native.LoadCursor(IntPtr.Zero, Native.IDC_ARROW);
            Native.RegisterClassEx(ref s_WndClass);

            m_Hwnd = Native.CreateWindowEx(
                0,
                "RimeRenderer",
                "",
                Native.WS_CHILD | Native.WS_VISIBLE,
                0,
                0,
                (int)Width,
                (int)Height,
                p_HwndParent.Handle,
                IntPtr.Zero,
                IntPtr.Zero,
                0
            );

            var s_MainWindowHandle = new WindowInteropHelper(Application.Current.MainWindow).Handle;
            m_RenderManager.InitializeGraphics(m_Hwnd, s_MainWindowHandle, GetSize());
            m_Initialized = true;

            return new HandleRef(this, m_Hwnd);
        }

        protected override void DestroyWindowCore(HandleRef p_Hwnd)
        {
            m_Initialized = false;
            m_RenderManager.Cleanup();
            Native.DestroyWindow(p_Hwnd.Handle);
            m_Hwnd = IntPtr.Zero;
        }

        protected override void OnRenderSizeChanged(SizeChangedInfo p_SizeInfo)
        {
            UpdateWindowPos();

            base.OnRenderSizeChanged(p_SizeInfo);

            if (m_Initialized)
                m_RenderManager.ResizeView(GetSize());
        }

        private Size GetSize()
        {
            var s_Width = (int) ActualWidth;
            var s_Height = (int) ActualHeight;

            if (s_Width <= 0)
                s_Width = 1;

            if (s_Height <= 0)
                s_Height = 1;

            return new Size(s_Width, s_Height);
        }
    }
}