using GameToolsDotNet.Bitmaps.Formats;
using GameToolsDotNet.Extensions;
using GameToolsDotNet.Rendering.DirectX.Misc;
using GameToolsDotNet.Rendering.DirectX.Shaders;
using GameToolsDotNet.Rendering.ImGuiUI.Controls;
using GameToolsDotNet.Utilities;
using ImGuiNET;
using SharpDX;
using SharpDX.Direct3D;
using SharpDX.Direct3D11;
using SharpDX.DXGI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Buffer = SharpDX.Direct3D11.Buffer;
using Device = SharpDX.Direct3D11.Device;
using ImVector2 = System.Numerics.Vector2;

namespace GameToolsDotNet.Rendering.DirectX
{
    public class RenderTime
    {
        // Global timing data:
        public long LastTickCount;                  // Tick count from the last frame
        public long CurrentTickCount;               // Tick count for the current frame
        public long InputPollTime;                  // Tick count for the last time input was polled at
        public float TimeDelta;                     // Time that has elapsed since the previous frame
    }

    public enum UpAxis
    {
        /// <summary>
        /// Y-Axis is the vertical axis
        /// </summary>
        Y_Up,
        /// <summary>
        /// Z-Axis is the vertical axis
        /// </summary>
        Z_Up
    }

    public class RenderConfig
    {
        /// <summary>
        /// If true enabled the D3D debug layer
        /// </summary>
        public bool DebugLayerEnabled { get; set; } = false;
        /// <summary>
        /// True to use a right hand perspective for rendering, false to use left hand perspective
        /// </summary>
        public bool RightHandPerspective { get; set; } = true;
        /// <summary>
        /// Determines which axis is used for the vertical axis
        /// </summary>
        public UpAxis UpAxis { get; set; } = UpAxis.Z_Up;
        /// <summary>
        /// Minimum distance to start drawing
        /// </summary>
        public float DrawDistanceMinimum { get; set; } = 1.0f;
        /// <summary>
        /// Maximum distance to draw to
        /// </summary>
        public float DrawDistanceMaximum { get; set; } = 10000.0f;
        /// <summary>
        /// Index of the adapter to use for rendering
        /// </summary>
        public int AdapterIndex { get; set; } = 0;
    }

    public abstract class RenderManager
    {
        /// <summary>
        /// Size of the image to render.
        /// </summary>
        public Size ViewSize { get; set; }

        private readonly RenderConfig configuration;
        /// <summary>
        /// Configuration for setting up the rendering engine.
        /// </summary>
        public RenderConfig Configuration { get { return this.configuration; } }

        /// <summary>
        /// D3D11 rendering device.
        /// </summary>
        public Device Device = null;

        public SwapChain SwapChain = null;
        public Texture2D BackBuffer { get; protected set; }
        public RenderTargetView RenderView { get; protected set; }
        public RasterizerState RasterizerState { get; protected set; }
        public RasterizerState NoCullingRasterizerState { get; protected set; }
        public BlendState DefaultBlendState { get; protected set; }
        public BlendState TransparencyBlendState { get; protected set; }

        public Texture2D DepthStencilTexture { get; protected set; }
        public DepthStencilView DepthStencilView { get; protected set; }
        public DepthStencilState DepthStencilState { get; protected set; }
        /// <summary>
        /// Value to clear the depth buffer with each frame
        /// </summary>
        public float DepthBufferDepthValue { get; set; } = 0f;
        /// <summary>
        /// Value to clear the depth stencil with each frame
        /// </summary>
        public byte DepthBufferStencilValue { get; set; } = 0;

        public DepthStencilState HighlightDepthStencilState { get; protected set; }

        protected Texture2D checkerboardTexture = null;
        public Texture2D CheckerboardTexture { get { return this.checkerboardTexture; } }

        protected ShaderResourceView checkerboardTextureResource = null;
        public ShaderResourceView CheckerboardTextureResource { get { return this.checkerboardTextureResource; } }

        /// <summary>
        /// Shader constants for the camera and scene.
        /// </summary>
        public ShaderConstantManager<ShaderConstants> CameraShaderConstants { get; private set; }
        /// <summary>
        /// Collection of shaders to render with.
        /// </summary>
        public ShaderCollection ShaderCollection { get; protected set; }

        /// <summary>
        /// Timing values for rendering and animation playback.
        /// </summary>
        public RenderTime RenderTime { get; set; } = new RenderTime();
        /// <summary>
        /// Input handler for polling mouse/keyboard/controller input.
        /// </summary>
        public InputManager InputManager { get; protected set; }

        /// <summary>
        /// Camera view of the rendered scene.
        /// </summary>
        public Camera Camera { get; set; }
        /// <summary>
        /// Projection matrix for the scene, based on field of view and render view size.
        /// </summary>
        public Matrix ProjectionMatrix { get; protected set; }
        /// <summary>
        ///  World matrix
        /// </summary>
        public Matrix WorldMatrix { get; protected set; } = Matrix.Identity;

        private float fieldOfView = 80.0f;
        /// <summary>
        /// Field of view for the projection matrix.
        /// </summary>
        public float FieldOfView { get { return this.fieldOfView; } set { this.fieldOfView = value; ResizeView(this.ViewSize); } }

        private float drawDistanceMin = 1.0f;
        /// <summary>
        /// Minimum distance to draw at
        /// </summary>
        public float DrawDistanceMin 
        { 
            get { return this.drawDistanceMin; } 
            set 
            {
                // Make sure the min draw distance is > 0 or the depth buffer will not work.
                if (value == 0f)
                    throw new ArgumentOutOfRangeException("Minimum draw distance must be > 0 or the depth buffer will not work. Try setting the draw distance to a very small but non-zero value instead");

                this.drawDistanceMin = value; 
                ResizeView(this.ViewSize); 
            } 
        }

        private float drawDistanceMax = 400000.0f;
        /// <summary>
        /// Maximum distance to draw at
        /// </summary>
        public float DrawDistanceMax { get { return this.drawDistanceMax; } set { this.drawDistanceMax = value; ResizeView(this.ViewSize); } }

        // Boudning box of the view frustum used for culling.
        protected Vector4 viewFrustumMin;
        protected Vector4 viewFrustumMax;
        public BoundingFrustum ViewFrustumBoundingBox { get; protected set; }

        /// <summary>
        /// Ray to trace from the cursor position on screen to world coordinates.
        /// </summary>
        public Ray MouseToWorldRay { get; protected set; }

        protected ImGuiRenderer uiRenderer = null;
        protected DepthStencilState uiDepthStencil = null;

        // List of resources to render each frame.
        protected List<RenderableGameResource> resourcesToRender = new List<RenderableGameResource>();

        protected HashSet<IPickableObject> selectedObjects = new HashSet<IPickableObject>();
        public IPickableObject[] SelectedObjects { get { return this.selectedObjects.ToArray(); } }

        // UI settings:

        private bool showCameraWindow = true;
        /// <summary>
        /// Indicates if the camera settings window should be visible or not
        /// </summary>
        public bool ShowCameraWindow { get { return this.showCameraWindow; } set { this.showCameraWindow = value; } }
        /// <summary>
        /// Gets or sets the position of the camera settings window
        /// </summary>
        public ImVector2 CameraWindowPosition = new ImVector2(10, 10);
        /// <summary>
        /// Gets or sets the size of the camera settings window
        /// </summary>
        public ImVector2 CameraWindowSize { get; set; }

        public RenderManager(RenderConfig configuration)
        {
            // Initialize fields.
            this.configuration = configuration;

            this.drawDistanceMin = this.configuration.DrawDistanceMinimum;
            this.drawDistanceMax = this.configuration.DrawDistanceMaximum;

            // Set the initial camera window size.
            this.CameraWindowSize = new ImVector2((this.ViewSize.Width / 4) - 20 - 30, 0);
        }

        #region D3D Init

        public bool InitializeGraphics(IntPtr renderTargetHandle, IntPtr windowHandle, Size viewSize)
        {
            ViewSize = viewSize;

            // Setup the swapchain description structure.
            SwapChainDescription desc = new SwapChainDescription();
            desc.BufferCount = 1;
            desc.ModeDescription = new ModeDescription(this.ViewSize.Width, this.ViewSize.Height, new Rational(60, 1), Format.R8G8B8A8_UNorm);
            desc.OutputHandle = renderTargetHandle;
            desc.SampleDescription = new SampleDescription(1, 0);
            desc.SwapEffect = SwapEffect.Discard;
            desc.Usage = Usage.RenderTargetOutput;
            desc.IsWindowed = true;

            // Check the adapter index is valid.
            Factory factory = new Factory1();
            if (this.configuration.AdapterIndex >= factory.GetAdapterCount())
            {
                // Specified index is bad, use default option instead.
                this.configuration.AdapterIndex = 0;
            }

            // Create the device and swapchain.
            DeviceCreationFlags deviceFlags = this.Configuration.DebugLayerEnabled == true ? DeviceCreationFlags.Debug : DeviceCreationFlags.None;
            Device.CreateWithSwapChain(factory.Adapters[this.configuration.AdapterIndex], deviceFlags, desc, out this.Device, out this.SwapChain);

            // Setup the projection matrix.
            if (this.Configuration.RightHandPerspective == true)
            {
                // Right-hand perspective:
                this.ProjectionMatrix = Matrix.PerspectiveFovRH(MathUtil.DegreesToRadians(this.FieldOfView),
                    (float)this.ViewSize.Width / (float)this.ViewSize.Height, this.DrawDistanceMax, this.DrawDistanceMin); // this.DrawDistanceMin, this.DrawDistanceMax);
            }
            else
            {
                // Left-hand perspective:
                this.ProjectionMatrix = Matrix.PerspectiveFovLH(MathUtil.DegreesToRadians(this.FieldOfView),
                    (float)this.ViewSize.Width / (float)this.ViewSize.Height, this.DrawDistanceMax, this.DrawDistanceMin); // this.DrawDistanceMin, this.DrawDistanceMax);
            }

            // Initialize the view frustum bounding box.
            this.viewFrustumMin = new Vector4(-(this.ViewSize.Width / 2f), 0.0f, this.DrawDistanceMin, 0.0f);
            this.viewFrustumMax = new Vector4(this.ViewSize.Width / 2f, this.ViewSize.Height, this.DrawDistanceMax, 0.0f);
            this.ViewFrustumBoundingBox = new BoundingFrustum();

            // Create our output texture for rendering.
            this.BackBuffer = Texture2D.FromSwapChain<Texture2D>(this.SwapChain, 0);
            this.RenderView = new RenderTargetView(this.Device, this.BackBuffer);

            // Create the depth stencil and depth stencil view.
            CreateDepthStencil();

            // Setup the depth stencil state.
            DepthStencilStateDescription stateDesc = new DepthStencilStateDescription();
            stateDesc.IsDepthEnabled = true;
            stateDesc.DepthWriteMask = DepthWriteMask.All;
            stateDesc.DepthComparison = Comparison.GreaterEqual;
            stateDesc.IsStencilEnabled = true;
            stateDesc.StencilReadMask = 0xFF;
            stateDesc.StencilWriteMask = 0xFF;
            stateDesc.FrontFace.FailOperation = StencilOperation.Keep;
            stateDesc.FrontFace.DepthFailOperation = StencilOperation.Keep;
            stateDesc.FrontFace.PassOperation = StencilOperation.Replace;
            stateDesc.FrontFace.Comparison = Comparison.Always;
            stateDesc.BackFace.FailOperation = StencilOperation.Keep;
            stateDesc.BackFace.DepthFailOperation = StencilOperation.Keep;
            stateDesc.BackFace.PassOperation = StencilOperation.Replace;
            stateDesc.BackFace.Comparison = Comparison.Always;
            this.DepthStencilState = new DepthStencilState(this.Device, stateDesc);

            // Setup the depth stencil state for object bleeding.
            stateDesc = new DepthStencilStateDescription();
            stateDesc.IsDepthEnabled = false;
            stateDesc.DepthWriteMask = DepthWriteMask.All;
            stateDesc.DepthComparison = Comparison.Always;
            stateDesc.IsStencilEnabled = false;
            stateDesc.StencilReadMask = 0xFF;
            stateDesc.StencilWriteMask = 0xFF;
            stateDesc.FrontFace.FailOperation = StencilOperation.Keep;
            stateDesc.FrontFace.DepthFailOperation = StencilOperation.Increment;
            stateDesc.FrontFace.PassOperation = StencilOperation.Keep;
            stateDesc.FrontFace.Comparison = Comparison.Less;
            stateDesc.BackFace.FailOperation = StencilOperation.Keep;
            stateDesc.BackFace.DepthFailOperation = StencilOperation.Decrement;
            stateDesc.BackFace.PassOperation = StencilOperation.Keep;
            stateDesc.BackFace.Comparison = Comparison.Less;
            this.HighlightDepthStencilState = new DepthStencilState(this.Device, stateDesc);

            // Setup the depth stencil state for the UI.
            stateDesc = new DepthStencilStateDescription();
            stateDesc.IsDepthEnabled = false;
            stateDesc.DepthWriteMask = DepthWriteMask.All;
            stateDesc.DepthComparison = Comparison.Always;
            stateDesc.IsStencilEnabled = false;
            stateDesc.StencilReadMask = 0xFF;
            stateDesc.StencilWriteMask = 0xFF;
            stateDesc.FrontFace.FailOperation = StencilOperation.Keep;
            stateDesc.FrontFace.DepthFailOperation = StencilOperation.Keep;
            stateDesc.FrontFace.PassOperation = StencilOperation.Replace;
            stateDesc.FrontFace.Comparison = Comparison.Always;
            stateDesc.BackFace.FailOperation = StencilOperation.Keep;
            stateDesc.BackFace.DepthFailOperation = StencilOperation.Keep;
            stateDesc.BackFace.PassOperation = StencilOperation.Replace;
            stateDesc.BackFace.Comparison = Comparison.Always;
            this.uiDepthStencil = new DepthStencilState(this.Device, stateDesc);

            // Setup the default rasterizer state.
            RasterizerStateDescription rasterStateDesc = new RasterizerStateDescription();
            rasterStateDesc.FillMode = FillMode.Solid;
            rasterStateDesc.CullMode = CullMode.Front;
            rasterStateDesc.IsDepthClipEnabled = true;
            this.RasterizerState = new RasterizerState(this.Device, rasterStateDesc);

            // Setup the no-culling rasterizer state.
            rasterStateDesc = new RasterizerStateDescription();
            rasterStateDesc.FillMode = FillMode.Wireframe;
            rasterStateDesc.CullMode = CullMode.None;
            rasterStateDesc.IsDepthClipEnabled = false;
            rasterStateDesc.DepthBias = (int)(-0.00001 / (1 / Math.Pow(2, 23)));
            this.NoCullingRasterizerState = new RasterizerState(this.Device, rasterStateDesc);

            // Setup the default blend state.
            BlendStateDescription blendDesc = new BlendStateDescription();
            blendDesc.AlphaToCoverageEnable = false;
            blendDesc.IndependentBlendEnable = false;
            blendDesc.RenderTarget[0].IsBlendEnabled = false;
            blendDesc.RenderTarget[0].SourceBlend = BlendOption.SourceAlpha;
            blendDesc.RenderTarget[0].DestinationBlend = BlendOption.InverseSourceAlpha;
            blendDesc.RenderTarget[0].BlendOperation = BlendOperation.Add;
            blendDesc.RenderTarget[0].SourceAlphaBlend = BlendOption.One;
            blendDesc.RenderTarget[0].DestinationAlphaBlend = BlendOption.One;
            blendDesc.RenderTarget[0].AlphaBlendOperation = BlendOperation.Add;
            blendDesc.RenderTarget[0].RenderTargetWriteMask = ColorWriteMaskFlags.All;
            this.DefaultBlendState = new BlendState(this.Device, blendDesc);

            // Setup the blend state for image transparency.
            blendDesc = new BlendStateDescription();
            blendDesc.AlphaToCoverageEnable = false;
            blendDesc.IndependentBlendEnable = false;
            blendDesc.RenderTarget[0].IsBlendEnabled = true;
            blendDesc.RenderTarget[0].SourceBlend = BlendOption.SourceAlpha;
            blendDesc.RenderTarget[0].DestinationBlend = BlendOption.InverseSourceAlpha;
            blendDesc.RenderTarget[0].BlendOperation = BlendOperation.Add;
            blendDesc.RenderTarget[0].SourceAlphaBlend = BlendOption.One;
            blendDesc.RenderTarget[0].DestinationAlphaBlend = BlendOption.One;
            blendDesc.RenderTarget[0].AlphaBlendOperation = BlendOperation.Add;
            blendDesc.RenderTarget[0].RenderTargetWriteMask = ColorWriteMaskFlags.All;
            this.TransparencyBlendState = new BlendState(this.Device, blendDesc);

            // Initialize the input manager.
            this.InputManager = new InputManager(windowHandle, renderTargetHandle);
            if (this.InputManager.InitializeGraphics(this) == false)
            {
                // Failed to initialize the input manager.
                throw new Exception("Failed to initialize input manager");
            }

            // Initialize the shader collection.
            this.ShaderCollection = new ShaderCollection();
            if (this.ShaderCollection.InitializeGraphics(this) == false)
            {
                // Failed to initialize shaders.
                throw new Exception("Failed to build shader collection");
            }

            // Initialize shader constants for the camera.
            this.CameraShaderConstants = new ShaderConstantManager<ShaderConstants>(0);
            if (this.CameraShaderConstants.InitializeGraphics(this) == false)
            {
                // Failed to create camera shader constants buffer.
                throw new Exception("Failed to create camera shader constants buffer");
            }

            // Create the camera.
            this.Camera = new Camera(this.Configuration.UpAxis, this.Configuration.RightHandPerspective);
            this.Camera.InitializeGraphics(this);

            // Create the ImGui rendering layer.
            this.uiRenderer = new ImGuiRenderer(this.ViewSize.Width, this.ViewSize.Height);
            if (this.uiRenderer.InitializeGraphics(this) == false)
            {
                // Failed to initialize ImGui rendering layer.
                throw new Exception("ImGui failed to initialize");
            }

            // Load textures for UI components.
            LoadTexture(Properties.Resources.CheckerBoard_dds, out this.checkerboardTexture, out this.checkerboardTextureResource);

            // Initialize game data.
            return InitializeGameData();
        }

        private void CreateDepthStencil()
        {
            // Create a texture for the depth stencil.
            Texture2DDescription depthStencilDesc = new Texture2DDescription();
            depthStencilDesc.Width = this.ViewSize.Width;
            depthStencilDesc.Height = this.ViewSize.Height;
            depthStencilDesc.MipLevels = 1;
            depthStencilDesc.ArraySize = 1;
            depthStencilDesc.Format = Format.D32_Float_S8X24_UInt;
            depthStencilDesc.SampleDescription.Count = 1;
            depthStencilDesc.SampleDescription.Quality = 0;
            depthStencilDesc.Usage = ResourceUsage.Default;
            depthStencilDesc.BindFlags = BindFlags.DepthStencil;
            this.DepthStencilTexture = new Texture2D(this.Device, depthStencilDesc);

            // Create the depth stencil view.
            DepthStencilViewDescription depthStencilViewDesc = new DepthStencilViewDescription();
            depthStencilViewDesc.Dimension = DepthStencilViewDimension.Texture2D;
            depthStencilViewDesc.Format = Format.D32_Float_S8X24_UInt;
            this.DepthStencilView = new DepthStencilView(this.Device, this.DepthStencilTexture, depthStencilViewDesc);
            this.DepthStencilView.DebugName = "primary depth stencil";
        }

        public bool LoadTexture(byte[] data, out Texture2D texture, out ShaderResourceView resource)
        {
            // Satisfy the compiler.
            texture = null;
            resource = null;

            // Parse the dds image from memory.
            DirectDrawSurface ddsImage = DirectDrawSurface.FromBuffer(data);
            if (ddsImage == null)
            {
                // Failed to load the texture from file.
                return false;
            }

            // Create the texture description.
            Texture2DDescription desc = new Texture2DDescription();
            desc.Width = ddsImage.Width;
            desc.Height = ddsImage.Height;
            desc.MipLevels = ddsImage.MipMapCount;
            desc.ArraySize = 1; // TODO: Support more than 2d textures
            desc.Format = ddsImage.Format;
            desc.Usage = ResourceUsage.Default;
            desc.BindFlags = BindFlags.ShaderResource;
            desc.SampleDescription.Count = 1;
            texture = new Texture2D(this.Device, desc);

            // Update the texture pixel buffer.
            this.Device.ImmediateContext.UpdateSubresource(ddsImage.PixelBuffer, texture);

            // Create the shader resource view.
            resource = new ShaderResourceView(this.Device, texture);

            // Successfully loaded the texture.
            return true;
        }

        protected virtual bool InitializeGameData()
        {
            // Setup the camera position, lookat, and speed.
            SetupCamera();

            // Now that we have placed the camera reset the view frustum bounding box.
            //this.ViewFrustumBoundingBox.Reset(Vector4.Transform(this.viewFrustumMin, this.Camera.ViewMatrix * this.ProjectionMatrix).ToVector3(), Vector4.Transform(this.viewFrustumMax, this.Camera.ViewMatrix * this.ProjectionMatrix).ToVector3());
            this.ViewFrustumBoundingBox = new BoundingFrustum(this.Camera.ViewMatrix * this.ProjectionMatrix);

            // Successfully initialized model data.
            return true;
        }

        /// <summary>
        /// Used to set the camera's initial position, direction, and speed.
        /// </summary>
        protected virtual void SetupCamera()
        {
            // Position the camera and make it look at the model.
            this.Camera.Position = new Vector3(0f, 0f, 0f);
            this.Camera.LookAt = new Vector3(0f, 0f, 5f);
            this.Camera.SpeedModifier = 5f;
        }

        #endregion

        #region Rendering

        public virtual void DrawFrame(bool isFocused)
        {
            // Update the time from the previous frame to the current frame.
            this.RenderTime.LastTickCount = this.RenderTime.CurrentTickCount;
            this.RenderTime.CurrentTickCount = DateTime.Now.Ticks;
            this.RenderTime.TimeDelta = (float)(this.RenderTime.CurrentTickCount - this.RenderTime.LastTickCount) / (float)TimeSpan.TicksPerSecond;

            // Render ImGui before polling for input so we can block out updating the view camera.
            RenderGuiLayerInternal(isFocused);

            // Cap input polling to 30 times per second.
            if ((this.RenderTime.CurrentTickCount - this.RenderTime.InputPollTime) > (TimeSpan.TicksPerSecond / 30))
            {
                // Only move the camera if the window is visible.
                if (isFocused == true)
                {
                    // Update input.
                    this.RenderTime.InputPollTime = DateTime.Now.Ticks;
                    this.InputManager.DrawFrame(this);

                    // If ImGui has focus, don't adjust the camera.
                    if (ImGui.GetIO().WantCaptureMouse == false)
                    {
                        // Update the mouse to worl ray.
                        this.MouseToWorldRay = CalculatePickingRay(this.InputManager.MousePosition, new Vector2(this.ViewSize.Width, this.ViewSize.Height));

                        // Loop through all the selected items and update input for them.
                        bool inputHandled = false;
                        foreach (IPickableObject selectedObject in this.selectedObjects)
                        {
                            // Let the object try to handle the input changes.
                            if (selectedObject.HandleInput(this) == true)
                                inputHandled = true;
                        }

                        // If none of the selected objects consumed the input changes then handle them here.
                        if (inputHandled == false)
                        {
                            // Update the camera.
                            this.Camera.DrawFrame(this);

                            // Update the bounding box for the view frustum.
                            //this.ViewFrustumBoundingBox.Reset(Vector4.Transform(this.viewFrustumMin, this.Camera.ViewMatrix * this.ProjectionMatrix).ToVector3(), Vector4.Transform(this.viewFrustumMax, this.Camera.ViewMatrix * this.ProjectionMatrix).ToVector3());
                            this.ViewFrustumBoundingBox = new BoundingFrustum(this.Camera.ViewMatrix * this.ProjectionMatrix);

                            //// Check if the left mouse button was pressed/released.
                            //if (this.InputManager.ButtonReleased(InputAction.LeftClick) == true)
                            //{
                            //    // Check if the mouse moved during the button press or not.
                            //    if (this.InputManager.MouseDownPosition == this.InputManager.MouseUpPosition)
                            //    {
                            //        int closestObjectIndex = -1;
                            //        float closestObjectDistance = float.MaxValue;
                            //        object closestObjectContext = null;

                            //        // If the control button is not being pressed then clear the selected item list.
                            //        if (this.InputManager.KeyboardState[(int)Keys.ControlKey] == false)
                            //        {
                            //            // Deselect all selected objects.
                            //            DeselectAllObjects();
                            //        }

                            //        // Calculate the picking ray.
                            //        Ray pickingRay = CalculatePickingRay(this.InputManager.MouseUpPosition, new Vector2(this.ViewSize.Width, this.ViewSize.Height));

                            //        // Loop through all of the resources to be rendered and perform a picking test.
                            //        for (int i = 0; i < this.resourcesToRender.Count; i++)
                            //        {
                            //            // If this object implements IPickableObject perform the picking test.
                            //            IPickableObject pickableObj = this.resourcesToRender[i].GameResource as IPickableObject;
                            //            if (pickableObj != null && pickableObj.DoPickingTest(this, pickingRay, null, out float distance, out object context) == true)
                            //            {
                            //                // Check if this object is closer than the closest object that passed the hit test.
                            //                if (distance < closestObjectDistance)
                            //                {
                            //                    // Set this object as the picked object.
                            //                    closestObjectIndex = i;
                            //                    closestObjectDistance = distance;
                            //                    closestObjectContext = context;
                            //                }
                            //            }
                            //        }

                            //        // If an object passed the hit test then set it as the selected object.
                            //        if (closestObjectIndex != -1)
                            //        {
                            //            // Set the object as selected.
                            //            SelectObject(closestObjectIndex, closestObjectContext);
                            //        }
                            //    }
                            //}
                        }
                    }
                }
            }

            // Update shader constants.
            UpdateShaderConstants();

            // Set our render target to our swapchain buffer.
            this.Device.ImmediateContext.OutputMerger.SetRenderTargets(this.DepthStencilView, this.RenderView);

            // Set the viewport.
            this.Device.ImmediateContext.Rasterizer.SetViewport(0, 0, this.ViewSize.Width, this.ViewSize.Height, 0.0f, 1.0f);

            // Clear the backbuffer.
            this.Device.ImmediateContext.ClearRenderTargetView(this.RenderView, SharpDX.Color.CornflowerBlue);
            this.Device.ImmediateContext.ClearDepthStencilView(this.DepthStencilView, DepthStencilClearFlags.Depth | DepthStencilClearFlags.Stencil, this.DepthBufferDepthValue, this.DepthBufferStencilValue);

            // Set depth stencil and rasterizer states.
            this.Device.ImmediateContext.OutputMerger.SetDepthStencilState(this.DepthStencilState, 0);
            this.Device.ImmediateContext.Rasterizer.State = this.RasterizerState;

            // Call the early draw frame function.
            DrawFrameEarly(isFocused);

            // Loop through all of the resources to render and draw each one.
            for (int i = 0; i < this.resourcesToRender.Count; i++)
            {
                // Draw the model.
                this.resourcesToRender[i].DrawFrame(this);
            }

            // Call the late draw frame function.
            DrawFrameLate(isFocused);

            // TODO: Move this to the ImGuiRenderer class
            // Update the WVP matrix so we are back at the origin for rendering the UI.
            //this.CameraShaderConstants.ShaderConstants.gWorldViewProjectionMatrix = Matrix.Transpose(this.WorldMatrix * this.Camera.ViewMatrix * this.ProjectionMatrix);
            //this.CameraShaderConstants.DrawFrame(this, true);

            // Do ImGui rendering for UI.
            this.Device.ImmediateContext.OutputMerger.SetDepthStencilState(this.uiDepthStencil, 0);
            this.uiRenderer.DrawFrame(this);

            // Present the final frame.
            this.SwapChain.Present(0, PresentFlags.None);
        }

        protected virtual void DrawFrameEarly(bool isFocused)
        {

        }

        protected virtual void DrawFrameLate(bool isFocused)
        {

        }

        public virtual void ResizeView(Size newSize)
        {
            // Update the view size.
            this.ViewSize = newSize;

            // Clear the current device state.
            this.Device.ImmediateContext.ClearState();

            // Release all references to the swap chain buffers.
            this.Device.ImmediateContext.OutputMerger.ResetTargets();
            this.RenderView.Dispose();
            this.BackBuffer.Dispose();

            // Dispose of the old depth stencil texture and create a new one.
            this.DepthStencilTexture.Dispose();
            this.DepthStencilView.Dispose();
            CreateDepthStencil();

            // Resize the swap chain.
            this.SwapChain.ResizeBuffers(1, this.ViewSize.Width, this.ViewSize.Height, Format.R8G8B8A8_UNorm, SwapChainFlags.None);
            this.BackBuffer = this.SwapChain.GetBackBuffer<Texture2D>(0);

            // Create a new render target view using the back buffer.
            this.RenderView = new RenderTargetView(this.Device, this.BackBuffer);

            // Update the projection matrix.
            if (this.Configuration.RightHandPerspective == true)
            {
                // Right-hand perspective:
                this.ProjectionMatrix = Matrix.PerspectiveFovRH(MathUtil.DegreesToRadians(this.FieldOfView),
                    (float)this.ViewSize.Width / (float)this.ViewSize.Height, this.DrawDistanceMax, this.DrawDistanceMin);
            }
            else
            {
                // Left-hand perspective:
                this.ProjectionMatrix = Matrix.PerspectiveFovLH(MathUtil.DegreesToRadians(this.FieldOfView),
                    (float)this.ViewSize.Width / (float)this.ViewSize.Height, this.DrawDistanceMax, this.DrawDistanceMin);
            }

            // Reset the view frustum bounding box.
            this.viewFrustumMin = new Vector4(-(this.ViewSize.Width / 2f), 0.0f, this.DrawDistanceMin, 0.0f);
            this.viewFrustumMax = new Vector4(this.ViewSize.Width / 2f, this.ViewSize.Height, this.DrawDistanceMax, 0.0f);
            //this.ViewFrustumBoundingBox.Reset(Vector4.Transform(this.viewFrustumMin, this.Camera.ViewMatrix * this.ProjectionMatrix).ToVector3(), Vector4.Transform(this.viewFrustumMax, this.Camera.ViewMatrix * this.ProjectionMatrix).ToVector3());
            this.ViewFrustumBoundingBox = new BoundingFrustum(this.Camera.ViewMatrix * this.ProjectionMatrix);
        }

        #endregion

        public virtual void Cleanup()
        {
            // Loop and cleanup all loaded game resources.
            for (int i = this.resourcesToRender.Count - 1; i >= 0; i--)
            {
                // Cleanup the current resource.
                this.resourcesToRender[i].CleanupGraphics(this);
                this.resourcesToRender.RemoveAt(i);
            }

            // TODO: Cleanup directx resources

            // Cleanup the directx device.
            this.Device.Dispose();
            this.Device = null;
        }

        #region UI rendering

        private void RenderGuiLayerInternal(bool isFocused)
        {
            // Get the IO structure.
            ImGuiIOPtr io = ImGui.GetIO();

            io.DisplaySize = new System.Numerics.Vector2(this.ViewSize.Width / 1.0f, this.ViewSize.Height / 1.0f);
            io.DisplayFramebufferScale = new System.Numerics.Vector2(1.0f, 1.0f);
            io.DeltaTime = this.RenderTime.TimeDelta;

            // Only update input if the window is in focus.
            if (isFocused == true)
            {
                // Update the mouse position and buttons.
                io.MousePos = new System.Numerics.Vector2(this.InputManager.MousePosition.X, this.InputManager.MousePosition.Y);
                io.MouseDown[0] = this.InputManager.ButtonState[(int)InputAction.LeftClick];
                io.MouseDown[1] = this.InputManager.ButtonState[(int)InputAction.RightClick];
                io.MouseDown[2] = this.InputManager.ButtonState[(int)InputAction.MiddleMouse];

                // Update mouse wheel position.
                if (this.InputManager.MousePositionDelta[2] != 0)
                {
                    io.MouseWheel += ((float)this.InputManager.MousePositionDelta[2] / 120.0f) / 20.0f;
                }

                // Update keyboard input special keys.
                io.KeyCtrl = this.InputManager.KeyboardState[(int)Keys.ControlKey];
                io.KeyShift = this.InputManager.KeyboardState[(int)Keys.ShiftKey];
                io.KeyAlt = this.InputManager.KeyboardState[(int)Keys.Menu];
                io.KeySuper = false;
            }

            // Draw ImGui layer.
            ImGui.NewFrame();
            {
                // Create the camera properties window.
                if (this.showCameraWindow == true && ImGui.Begin("Camera", ref this.showCameraWindow) == true)
                {
                    // Set window size and position.
                    ImGui.SetWindowSize(this.CameraWindowSize, ImGuiCond.Once);
                    ImGui.SetWindowPos(this.CameraWindowPosition, ImGuiCond.Once);

                    // Position:
                    Vector3 camPosition = this.Camera.Position;
                    if (ImGui.InputFloat3("Position", ref camPosition) == true)
                        this.Camera.Position = camPosition;

                    // Angle:
                    Vector2 camRotation = this.Camera.Rotation;
                    if (ImGui.InputFloat2("Rotation", ref camRotation) == true)
                        this.Camera.Rotation = camRotation;

                    // Speed:
                    float camSpeed = this.Camera.Speed;
                    if (ImGui.InputFloat("Movement Speed", ref camSpeed) == true)
                        this.Camera.Speed = camSpeed;

                    // Field of view:
                    if (ImGui.InputFloat("Field of view", ref this.fieldOfView, 1.0f) == true)
                        this.ResizeView(this.ViewSize);

                    // Draw distance min:
                    float minDistance = this.drawDistanceMin;
                    if (ImGui.InputFloat("Draw distance min", ref this.drawDistanceMin) == true)
                    {
                        // Make sure the draw distance is non-zero.
                        if (this.drawDistanceMin != 0)
                            this.ResizeView(this.ViewSize);
                        else
                        {
                            // Revert the change.
                            this.drawDistanceMin = minDistance;
                        }
                    }

                    // Draw distance max:
                    if (ImGui.InputFloat("Draw distance max", ref this.drawDistanceMax) == true)
                        this.ResizeView(this.ViewSize);

                    // Calculate the position of the next window.
                    this.CameraWindowSize = ImGui.GetWindowSize();
                    this.CameraWindowPosition = ImGui.GetWindowPos();

                    ImGui.End();
                }

                // Draw any custom UI elements.
                RenderGuiLayer(isFocused);

                // Loop and draw the UI for any objects with a properties window open.
                for (int i = 0; i < this.resourcesToRender.Count; i++)
                {
                    this.resourcesToRender[i].DrawObjectPropertiesUI(this);
                }
            }

            ImGui.Render();
        }

        protected virtual void RenderGuiLayer(bool isFocused)
        {

        }

        #endregion

        #region Manager Functions

        /// <summary>
        /// Gets the game resource with the specified file name if it exists or null otherwise. If the game
        /// resource is created successfully the InitializeGraphics function is called to prepare it for rendering.
        /// </summary>
        /// <typeparam name="T">Object type of the game resource</typeparam>
        /// <param name="fileName">File name of the resource to get</param>
        /// <returns>Game resource instance if found and successfully initialized, or null otherwise</returns>
        public T GetResourceFromFileName<T>(string fileName)
        {
            return (T)GetResourceFromFileName(fileName);
        }

        /// <summary>
        /// Gets the game resource with the specified file name if it exists or null otherwise. If the game
        /// resource is created successfully the InitializeGraphics function is called to prepare it for rendering.
        /// </summary>
        /// <param name="fileName">File name of the resource to get</param>
        /// <returns>Game resource instance if found and successfully initialized, or null otherwise</returns>
        public abstract object GetResourceFromFileName(string fileName);

        public T GetResourceFromKey<T>(object key)
        {
            return (T)GetResourceFromKey(key);
        }

        public abstract object GetResourceFromKey(object key);

        public virtual void UpdateShaderConstants()
        {
            // Update the shader constants buffer with the new data and bind it to the pipeline.
            this.CameraShaderConstants.ShaderConstants.gCameraPosition = new Vector4(Camera.Position, 1f);
            this.CameraShaderConstants.ShaderConstants.gWorldViewProjectionMatrix = Matrix.Transpose(this.WorldMatrix * this.Camera.ViewMatrix * this.ProjectionMatrix);
            this.CameraShaderConstants.DrawFrame(this, true);
        }

        #endregion

        #region Object Picking

        protected Ray CalculatePickingRay(System.Drawing.Point position, Vector2 bounds)
        {
            Vector3 pickRayDir;
            Vector3 pickRayPos = new Vector3(0.0f);

            // Convert the 2d position into a ray in projection space.
            float x = (((2.0f * (float)position.X) / bounds.X) - 1) / this.ProjectionMatrix.M11;
            float y = -(((2.0f * (float)position.Y) / bounds.Y) - 1) / this.ProjectionMatrix.M22;
            float z = -1.0f;
            pickRayDir = new Vector3(x, y, z);

            // Get the inverse of the view space matrix.
            Matrix invViewMatrix = this.Camera.ViewMatrix;
            invViewMatrix.Invert();

            // Transform the pick ray in projection space to be in world space.
            Ray pickingRay = new Ray(Vector3.TransformCoordinate(pickRayPos, invViewMatrix), Vector3.TransformNormal(pickRayDir, invViewMatrix));
            pickingRay.Direction.Normalize();

            return pickingRay;
        }

        protected bool SelectObject(int objectIndex, object context)
        {
            // Get the object as an IPickableObject.
            IPickableObject selectedObject = this.resourcesToRender[objectIndex].GameResource as IPickableObject;
            if (selectedObject == null)
                return false;

            // Add the selected object and to the select objects set.
            this.selectedObjects.Add(selectedObject);
            selectedObject.SelectObject(this, context);

            // Item successfully selected.
            return true;
        }

        protected void DeselectObject(int objectIndex, object context)
        {
            // Get the object as an IPickableObject.
            IPickableObject selectedObject = this.resourcesToRender[objectIndex] as IPickableObject;
            if (selectedObject == null)
                return;

            // Deselect the object using the provided context and remove it from the selected objects set if needed.
            if (selectedObject.DeselectObject(this, context) == true)
            {
                // Remove the object from the selected objects set.
                this.selectedObjects.Remove(selectedObject);
            }
        }

        protected void DeselectAllObjects()
        {
            // Loop through the selected objects set and deselect all objects.
            foreach (IPickableObject selectedObject in this.selectedObjects)
            {
                // Deselect the object with no context to force deselection of all child objects.
                selectedObject.DeselectObject(this, null);
            }

            // Clear the selected objects set.
            this.selectedObjects.Clear();
        }

        #endregion
    }
}
