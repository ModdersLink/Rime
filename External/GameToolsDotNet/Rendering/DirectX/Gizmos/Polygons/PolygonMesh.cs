using GameToolsDotNet.Rendering.DirectX.Misc;
using GameToolsDotNet.Rendering.DirectX.Shaders;
using GameToolsDotNet.Rendering.Interfaces;
using SharpDX;
using SharpDX.Direct3D11;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buffer = SharpDX.Direct3D11.Buffer;

namespace GameToolsDotNet.Rendering.DirectX.Gizmos.Polygons
{
    public class PolygonMesh : IRenderable
    {
        /// <summary>
        /// This struct is "glue" between Polygon and PolygonStream.
        /// </summary>
        public struct PolygonMeshInfo
        {
            public int BaseVertex;
            public int BaseIndex;
        }

        /// <summary>
        /// Array of polygons in the stream.
        /// </summary>
        public Polygon[] Polygons { get; private set; }
        private PolygonMeshInfo[] polygonMeshInfo;

        private Vector3 position;
        /// <summary>
        /// Base position of the polygon stream.
        /// </summary>
        public Vector3 Position { get { return this.position; } set { this.position = value; UpdateTransformationMatrix(); } }

        private Quaternion rotation;
        /// <summary>
        /// Base rotation of the polygon stream.
        /// </summary>
        public Quaternion Rotation { get { return this.rotation; } set { this.rotation = value; UpdateTransformationMatrix(); } }

        /// <summary>
        /// Number of vertices the mesh can hold.
        /// </summary>
        public int VertexCount { get { return (this.vertexStream != null ? this.vertexStream.Vertices.Length : 0); } }
        /// <summary>
        /// Number of vertex indices the mesh can hold.
        /// </summary>
        public int IndexCount { get { return (this.vertexStream != null ? this.vertexStream.Indices.Length : 0); } }

        /// <summary>
        /// Transformation matrix for the stream, only updated when Position or Rotation change.
        /// </summary>
        public Matrix TransformationMatrix { get; protected set; }

        // Vertex and index buffers that hold all polygon data.
        private VertexStream<WireframeShader.Vertex, ushort> vertexStream;
        private Buffer vertexBuffer = null;
        private Buffer indexBuffer = null;

        // Shader instance.
        private Shader wireframeShader;

        // Rasterizer states.
        private RasterizerState wireframeRasterizerState;
        private RasterizerState solidRasterizerState;

        public PolygonMesh(Vector3 position, Quaternion rotation, params Polygon[] polygons)
        {
            // Initialize fields.
            this.Position = position;
            this.Rotation = rotation;
            this.Polygons = polygons;
        }

        private void UpdateTransformationMatrix()
        {
            // Calculate the transformation matrix.
            this.TransformationMatrix = Matrix.Transformation(Vector3.Zero, Quaternion.Zero, Vector3.One, Vector3.Zero, this.rotation, this.position);
        }

        #region IRenderable

        public bool InitializeGraphics(RenderManager manager, params object[] args)
        {
            // Allocate the mesh info array.
            this.polygonMeshInfo = new PolygonMeshInfo[this.Polygons.Length];

            // Loop through all of the polygons and compute the size needed for the vertex and index buffers.
            int vertexCount = 0, indexCount = 0;
            for (int i = 0; i < this.Polygons.Length; i++)
            {
                // Update the mesh info starting positions.
                this.polygonMeshInfo[i].BaseVertex = vertexCount;
                this.polygonMeshInfo[i].BaseIndex = indexCount;

                // Update the counters.
                vertexCount += this.Polygons[i].MaxVertexCount;
                indexCount += this.Polygons[i].MaxIndexCount;
            }

            // Create the vertex stream and fill it with the polygon data.
            this.vertexStream = new VertexStream<WireframeShader.Vertex, ushort>(vertexCount, indexCount);
            for (int i = 0; i < this.Polygons.Length; i++)
            {
                // Create a new splice for the vertex and index data for this polygon.
                VertexStreamSplice<WireframeShader.Vertex> vertexData = this.vertexStream.SpliceVertexBuffer(this.polygonMeshInfo[i].BaseVertex, this.Polygons[i].MaxVertexCount);
                VertexStreamSplice<ushort> indexData = this.vertexStream.SpliceIndexBuffer(this.polygonMeshInfo[i].BaseIndex, this.Polygons[i].MaxIndexCount);

                // Build the polygon mesh which will update the vertex stream.
                this.Polygons[i].BuildMesh(vertexData, indexData);
            }

            // Create the vertex and index buffers.
            this.vertexBuffer = Buffer.Create(manager.Device, BindFlags.VertexBuffer, this.vertexStream.Vertices);
            this.indexBuffer = Buffer.Create(manager.Device, BindFlags.IndexBuffer, this.vertexStream.Indices);

            // Get the wireframe shader.
            this.wireframeShader = manager.ShaderCollection.GetShader(ShaderType.Wireframe);

            // Setup the solid and wireframe rasterizer states.
            RasterizerStateDescription rasterStateDesc = new RasterizerStateDescription();
            rasterStateDesc.FillMode = FillMode.Wireframe;
            rasterStateDesc.CullMode = CullMode.None;
            rasterStateDesc.IsDepthClipEnabled = true;
            this.wireframeRasterizerState = new RasterizerState(manager.Device, rasterStateDesc);

            rasterStateDesc = new RasterizerStateDescription();
            rasterStateDesc.FillMode = FillMode.Solid;
            rasterStateDesc.CullMode = CullMode.None;
            rasterStateDesc.IsDepthClipEnabled = true;
            this.solidRasterizerState = new RasterizerState(manager.Device, rasterStateDesc);

            // Successfully initialized.
            return true;
        }

        public bool DrawFrame(RenderManager manager, params object[] args)
        {
            // Loop and check if any of the polygons are dirty and require updating.
            bool isDirty = false;
            for (int i = 0; i < this.Polygons.Length; i++)
            {
                // If the polygon is dirty flag that we need to update and rebuild the polygon.
                if (this.Polygons[i].IsDirty == true)
                {
                    // Flag that we need to update.
                    isDirty = true;

                    // Create a new splice for the vertex and index data for this polygon.
                    VertexStreamSplice<WireframeShader.Vertex> vertexData = this.vertexStream.SpliceVertexBuffer(this.polygonMeshInfo[i].BaseVertex, this.Polygons[i].MaxVertexCount);
                    VertexStreamSplice<ushort> indexData = this.vertexStream.SpliceIndexBuffer(this.polygonMeshInfo[i].BaseIndex, this.Polygons[i].MaxIndexCount);

                    // Rebuild the polygon mesh which updates the vertex buffer.
                    this.Polygons[i].BuildMesh(vertexData, indexData);
                }
            }

            // If one or more polygons are dirty update the entire vertex and index buffers.
            if (isDirty == true)
            {
                // Update the vertex and index buffers.
                manager.Device.ImmediateContext.UpdateSubresource(this.vertexStream.Vertices, this.vertexBuffer);
                manager.Device.ImmediateContext.UpdateSubresource(this.vertexStream.Indices, this.indexBuffer);
            }

            // Set the vertex and index buffers.
            manager.Device.ImmediateContext.InputAssembler.SetVertexBuffers(0, new VertexBufferBinding(this.vertexBuffer, WireframeShader.Vertex.kSizeOf, 0));
            manager.Device.ImmediateContext.InputAssembler.SetIndexBuffer(this.indexBuffer, SharpDX.DXGI.Format.R16_UInt, 0);

            // Setup the wireframe shader.
            this.wireframeShader.DrawFrame(manager);

            // Set the blend state for transparency.
            manager.Device.ImmediateContext.OutputMerger.BlendState = manager.TransparencyBlendState;

            // Loop and draw each polygon.
            for (int i = 0; i < this.Polygons.Length; i++)
            {
                // If the polygon is not visible skip drawing it.
                if (this.Polygons[i].Visible == false)
                    continue;

                // Set the rasterizer state based on the polygon style.
                if (this.Polygons[i].Style == PolygonDrawStyle.Outline)
                    manager.Device.ImmediateContext.Rasterizer.State = this.wireframeRasterizerState;
                else
                    manager.Device.ImmediateContext.Rasterizer.State = this.solidRasterizerState;

                // Do any per-polygon device state changes that need to be done.
                this.Polygons[i].DrawFrame(manager);

                // Compute the transformation matrix and update shader constants.
                //Matrix transform = Matrix.Transformation(Vector3.Zero, Quaternion.Zero, Vector3.One, -this.Polygons[i].Position, this.rotation * this.Polygons[i].Rotation, this.position + this.Polygons[i].Position);
                manager.CameraShaderConstants.ShaderConstants.gWorldViewProjectionMatrix = Matrix.Transpose(this.Polygons[i].TransformationMatrix * this.TransformationMatrix * manager.Camera.ViewMatrix * manager.ProjectionMatrix);
                manager.UpdateShaderConstants();

                // TODO: This should be more efficient than updating the shaders constants buffer for every polygon. Perhaps create another buffer
                //          that has all the transformation matrices in it.

                // Set the primitive type based on the render style.
                manager.Device.ImmediateContext.InputAssembler.PrimitiveTopology = this.Polygons[i].PrimitiveTopology;

                // Draw the polygon.
                manager.Device.ImmediateContext.DrawIndexed(this.Polygons[i].IndexCount, this.polygonMeshInfo[i].BaseIndex, this.polygonMeshInfo[i].BaseVertex);
            }

            // Mesh rendered successfully.
            return true;
        }

        public void DrawObjectPropertiesUI(RenderManager manager, object context = null)
        {
            throw new NotImplementedException();
        }

        public void CleanupGraphics(RenderManager manager, object context = null)
        {
            if (this.vertexBuffer != null)
                this.vertexBuffer.Dispose();
            if (this.indexBuffer != null)
                this.indexBuffer.Dispose();
        }

        public bool DoClippingTest(RenderManager manager, FastBoundingBox viewBox, object context = null)
        {
            // Always return true since we we handle clipping in the DrawFrame function.
            return true;
        }

        #endregion
    }
}
