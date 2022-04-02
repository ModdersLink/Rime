using GameToolsDotNet.Rendering.DirectX.Misc;
using GameToolsDotNet.Extensions;
using ImGuiNET;
using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameToolsDotNet.Rendering.Interfaces;

namespace GameToolsDotNet.Rendering.DirectX
{
    public class RenderableGameResource : IRenderable
    {
        /// <summary>
        /// Game resource to be rendered
        /// </summary>
        public IRenderable GameResource { get; private set; }
        /// <summary>
        /// World position of the resource
        /// </summary>
        public Vector3 Position { get; set; } = Vector3.Zero;
        /// <summary>
        /// Rotation to be applied to the resource
        /// </summary>
        public Quaternion Rotation { get; set; } = Quaternion.Identity;

        protected bool uiVisible = false;
        /// <summary>
        /// Determins if the object properties UI is currently being displayed for the object
        /// </summary>
        public bool UIVisible { get { return this.uiVisible; } set { this.uiVisible = value; } }

        public RenderableGameResource(IRenderable resource)
        {
            this.GameResource = resource;
        }

        public RenderableGameResource(IRenderable resource, Vector3 position, Quaternion rotation)
        {
            // Initialize fields.
            this.GameResource = resource;
            this.Position = position;
            this.Rotation = rotation;
        }

        #region IRenderable

        public bool InitializeGraphics(RenderManager manager, params object[] args)
        {
            // Initialize graphics for the game resource.
            return this.GameResource.InitializeGraphics(manager, args);
        }

        public virtual bool DrawFrame(RenderManager manager, params object[] args)
        {
            // Render the game resource.
            return this.GameResource.DrawFrame(manager, args);
        }

        public void DrawObjectPropertiesUI(RenderManager manager, object context = null)
        {
            // If the UI is currently active draw it.
            if (this.UIVisible == true)
            {
                // Create the object properties window.
#warning unfixed
                if (ImGui.Begin("Object Properties - " /*+ this.GameResource.FileName*/, ref this.uiVisible) == true)
                {
                    // Set the window position and size on first open.
                    ImGui.SetWindowPos(new System.Numerics.Vector2(manager.ViewSize.Width - (manager.ViewSize.Width / 4) - 10, 10), ImGuiCond.Once);
                    ImGui.SetWindowSize(new System.Numerics.Vector2(manager.ViewSize.Width / 4, manager.ViewSize.Height - 20), ImGuiCond.Once);

                    // Render the properties UI.
                    this.GameResource.DrawObjectPropertiesUI(manager, context);

                    // End the window.
                    ImGui.End();
                }
            }
        }

        public void CleanupGraphics(RenderManager manager, object context = null)
        {
            // Cleanup resource graphics objects.
            this.GameResource.CleanupGraphics(manager, context);
        }

        public bool DoClippingTest(RenderManager manager, FastBoundingBox viewBox, object context = null)
        {
            // TODO: Implement this
            return true;
        }

        #endregion
    }
}
