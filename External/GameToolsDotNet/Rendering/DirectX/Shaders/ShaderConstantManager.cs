using GameToolsDotNet.Rendering.DirectX.Misc;
using GameToolsDotNet.Rendering.Interfaces;
using SharpDX;
using SharpDX.Direct3D11;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Buffer = SharpDX.Direct3D11.Buffer;

namespace GameToolsDotNet.Rendering.DirectX.Shaders
{
    [StructLayout(LayoutKind.Sequential, Size = kSizeOf)]
    public struct ShaderConstants
    {
        public const int kSizeOf = (4 * 4 * 4) + 16;

        /// <summary>
        /// World * View * Projection matrix
        /// </summary>
        public Matrix gWorldViewProjectionMatrix;
        /// <summary>
        /// Camera position
        /// </summary>
        public Vector4 gCameraPosition;
    }

    public class ShaderConstantManager<T> : IRenderable where T : struct
    {
        /// <summary>
        /// Shader variables used during VS/PS stages.
        /// </summary>
        public T ShaderConstants = new T();

        /// <summary>
        /// Buffer used for sending shader constants to the shader pipeline.
        /// </summary>
        public Buffer ShaderConstantsBuffer { get; protected set; }

        /// <summary>
        /// Slot number this constant buffer is bound to.
        /// </summary>
        public int ConstantBufferSlot { get; set; }

        /// <summary>
        /// Creates a new ShaderConstantManager instance
        /// </summary>
        /// <param name="bufferSlot">Slot number the shader constant buffer is bound to</param>
        public ShaderConstantManager(int bufferSlot)
        {
            // Initialize fields.
            this.ConstantBufferSlot = bufferSlot;
        }

        public void UpdateShaderConstants(RenderManager manager)
        {
            // Update the shader constants buffer with the new data.
            manager.Device.ImmediateContext.UpdateSubresource(ref this.ShaderConstants, this.ShaderConstantsBuffer);
        }

        #region IRenderable

        public bool InitializeGraphics(RenderManager manager, params object[] args)
        {
            int structureSize = 0;

            try
            {
                // Get the size of the shader constants structure.
                StructLayoutAttribute structLayout = typeof(T).StructLayoutAttribute;
                structureSize = structLayout.Size;

                // Make sure the size is non-zero.
                if (structureSize == 0)
                    throw new Exception();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Shader constants structure must have a StructLayoutAttribute with the size parameter set");
            }

            // Pad the constant buffer out to a 16 byte alignment.
            int padding = (structureSize % 16) > 0 ? 16 - (structureSize % 16) : 0;

            // Create a shader constants buffer.
            this.ShaderConstantsBuffer = Buffer.Create(manager.Device, BindFlags.ConstantBuffer, ref this.ShaderConstants, structureSize + padding);

            return true;
        }

        public bool DrawFrame(RenderManager manager, params object[] args)
        {
            return DrawFrame(manager, args.Length > 0 ? (bool)args[0] : false);
        }

        public bool DrawFrame(RenderManager manager, bool updateShaderConstants)
        {
            // Check if we need to update the shader constants buffer.
            if (updateShaderConstants == true)
            {
                // Update the shader constants buffer with the new data.
                manager.Device.ImmediateContext.UpdateSubresource(ref this.ShaderConstants, this.ShaderConstantsBuffer);
            }

            // Set the shader constants.
            manager.Device.ImmediateContext.VertexShader.SetConstantBuffer(this.ConstantBufferSlot, this.ShaderConstantsBuffer);
            manager.Device.ImmediateContext.PixelShader.SetConstantBuffer(this.ConstantBufferSlot, this.ShaderConstantsBuffer);

            return true;
        }

        public void CleanupGraphics(RenderManager manager, object context = null)
        {
            throw new NotImplementedException();
        }

        public bool DoClippingTest(RenderManager manager, FastBoundingBox viewBox, object context = null)
        {
            throw new NotImplementedException();
        }

        public void DrawObjectPropertiesUI(RenderManager manager, object context = null)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
