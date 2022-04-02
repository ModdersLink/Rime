using GameToolsDotNet.Rendering.DirectX;
using GameToolsDotNet.Rendering.DirectX.Misc;
using SharpDX;
using SharpDX.Direct3D11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameToolsDotNet.Rendering.Interfaces
{
    public interface IRenderable
    {
        /// <summary>
        /// Called during DirectX initialization, create any resources needed to render this object
        /// </summary>
        /// <param name="manager">Rendering context</param>
        /// <param name="context">Additional user provided context parameter</param>
        /// <returns>True if initialization was successful, false otherwise</returns>
        bool InitializeGraphics(RenderManager manager, params object[] args);

        /// <summary>
        /// Called during the render loop, draws the object to screen
        /// </summary>
        /// <param name="manager">Rendering context</param>
        /// <param name="args">Additional user provided context parameter</param>
        /// <returns></returns>
        bool DrawFrame(RenderManager manager, params object[] args);

        /// <summary>
        /// Called during teardown, dispose of any rendering resources created
        /// </summary>
        /// <param name="manager">Rendering context</param>
        /// <param name="context">Additional user provided context parameter</param>
        void CleanupGraphics(RenderManager manager, object context = null);

        /// <summary>
        /// Called when the object properties UI for the object should be drawn.
        /// </summary>
        /// <param name="manager">Rendering context</param>
        /// <param name="context">Additional user provided context parameter</param>
        void DrawObjectPropertiesUI(RenderManager manager, object context = null);

        bool DoClippingTest(RenderManager manager, FastBoundingBox viewBox, object context = null);
    }
}
