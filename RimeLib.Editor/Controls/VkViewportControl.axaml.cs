using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using Avalonia.Rendering.Composition;
using Avalonia.Threading;
using RimeLib.Editor.Managers.Input;

namespace RimeLib.Editor.Controls
{
    // https://github.com/AvaloniaUI/Avalonia/blob/main/samples/GpuInterop/DrawingSurfaceDemoBase.cs

    public partial class VkViewportControl : UserControl
    {
        private Compositor? m_Compositor;
        private CompositionDrawingSurface? m_DrawingSurface;
        private ICompositionGpuInterop? m_GpuInterop;
        private ICompositionImportedGpuImage? m_ImportedGpuImage;
        private ICompositionImportedGpuSemaphore? m_GpuSemaphore;

        // Handle inputs from multiple devices
        private InputManager? m_InputManager;

        public VkViewportControl()
        {
            InitializeComponent();

            Focusable = true;
            ClipToBounds = true;
        }

        public override void Render(DrawingContext p_Context)
        {
            // Ensure the control has a hit-testable background for mouse events
            p_Context.FillRectangle(Brushes.Transparent, new Rect(Bounds.Size));
            base.Render(p_Context);
        }

        protected override async void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs p_EventArgs)
        {
            base.OnAttachedToVisualTree(p_EventArgs);

            // TODO: Initialize Input Manager
            // TODO: Initialize Vulkan Interop
            await InitializeVulkanInteropAsync();

            // Start a ~60 FPS render and controller polling loop
            DispatcherTimer.Run(OnFrameTick, TimeSpan.FromMilliseconds(16));
        }

        protected override void OnDetachedFromVisualTree(VisualTreeAttachmentEventArgs e)
        {
            // TODO: Cleanup Input Manager
            m_ImportedGpuImage?.DisposeAsync();
            m_GpuSemaphore?.DisposeAsync();
            m_DrawingSurface?.Dispose();

            base.OnDetachedFromVisualTree(e);
        }

        private async Task InitializeVulkanInteropAsync()
        {
            var s_Visual = ElementComposition.GetElementVisual(this);
            if (s_Visual is null)
                return;

            m_Compositor = s_Visual.Compositor;
            m_GpuInterop = await m_Compositor.TryGetCompositionGpuInterop();

            if (m_GpuInterop is null)
                throw new PlatformNotSupportedException("GPU Interop not supported on this platform.");

            m_DrawingSurface = m_Compositor.CreateDrawingSurface();

            var s_SurfaceVisual = m_Compositor.CreateSurfaceVisual();
            s_SurfaceVisual.Surface = m_DrawingSurface;
            s_SurfaceVisual.Size = new Vector(Bounds.Width, Bounds.Height);

            ElementComposition.SetElementChildVisual(this, s_SurfaceVisual);

            InitializeVulkanResources();
        }

        private void InitializeVulkanResources()
        {
            // 1. Create your VkInstance, VkPhysicalDevice, and VkDevice matching _gpuInterop.DeviceUuid / DeviceLuid.
            // 2. Allocate a VkImage with VkExternalMemoryImageCreateInfo (OpaqueWin32 / OpaqueFd).
            // 3. Export the memory handle and pass it to _gpuInterop.ImportImage(platformHandle, properties).
            // 4. Export a VkSemaphore handle and pass it to _gpuInterop.ImportSemaphore(semaphoreHandle).
        }

        private bool OnFrameTick()
        {
            if (m_DrawingSurface is null || m_GpuInterop is null || m_GpuInterop.IsLost)
                return false;

            // TODO: Poll Gamepad Input
            // TODO: Update Simulation
            RenderVulkanFrame();

            return VisualRoot is not null;
        }

        private void RenderVulkanFrame()
        {
            if (m_DrawingSurface is null || m_ImportedGpuImage is null)
                return;
        }

        protected override void OnSizeChanged(SizeChangedEventArgs p_EventArgs)
        {
            base.OnSizeChanged(p_EventArgs);

            if (ElementComposition.GetElementChildVisual(this) is CompositionSurfaceVisual s_CompSurfaceVisual)
            {
                s_CompSurfaceVisual.Size = new Vector(p_EventArgs.NewSize.Width, p_EventArgs.NewSize.Height);
            }

            // TODO: Recreate swap/offscreen VkImage and re-import it
        }

        protected override void OnKeyDown(Avalonia.Input.KeyEventArgs e)
        {
            base.OnKeyDown(e);
        }

        protected override void OnKeyUp(Avalonia.Input.KeyEventArgs e)
        {
            base.OnKeyUp(e);
        }

        protected override void OnLostFocus(Avalonia.Input.FocusChangedEventArgs e)
        {
            base.OnLostFocus(e);
        }

        protected override void OnPointerPressed(Avalonia.Input.PointerPressedEventArgs e)
        {
            base.OnPointerPressed(e);
        }

        protected override void OnPointerMoved(Avalonia.Input.PointerEventArgs e)
        {
            base.OnPointerMoved(e);
        }

        protected override void OnPointerReleased(Avalonia.Input.PointerReleasedEventArgs e)
        {
            base.OnPointerReleased(e);
        }

        protected override void OnPointerWheelChanged(Avalonia.Input.PointerWheelEventArgs e)
        {
            base.OnPointerWheelChanged(e);
        }
    }
}