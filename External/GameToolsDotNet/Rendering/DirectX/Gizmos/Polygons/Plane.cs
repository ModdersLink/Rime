using GameToolsDotNet.Rendering.DirectX.Misc;
using GameToolsDotNet.Rendering.DirectX.Shaders;
using SharpDX;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameToolsDotNet.Rendering.DirectX.Gizmos.Polygons
{
    public class Plane : Polygon, IPickableObject
    {
        private float width = 0f;
        public float Width { get { return this.width; } set { if (value != this.width) { this.width = value; this.IsDirty = true; } } }

        private float height = 0f;
        public float Height { get { return this.height; } set { if (value != this.height) { this.height = value; this.IsDirty = true; } } }

        private float scale = 1f;
        public float Scale { get { return this.scale; } set { if (value != this.scale) { this.scale = value; this.IsDirty = true; } } }

        private Color4 lineColor = new Color4(0xFF00FF00);
        public Color4 LineColor { get { return this.lineColor; } set { if (this.lineColor != value) { this.lineColor = value; this.IsDirty = true; } } }

        public Plane(float width, float height, Vector3 position, Quaternion rotation, PolygonDrawStyle style = PolygonDrawStyle.Outline)
            : base(4, 8, position, rotation)
        {
            // Initialize fields.
            this.width = width;
            this.height = height;
            this.Style = style;

            this.PrimitiveTopology = SharpDX.Direct3D.PrimitiveTopology.LineList;
        }

        public override void BuildMesh(VertexStreamSplice<WireframeShader.Vertex> vertexBuffer, VertexStreamSplice<ushort> indexBuffer)
        {
            // Scale the size of the plane.
            float scaledWidth = this.Width * this.Scale;
            float scaledHeight = this.Height * this.Scale;

            // Calculate the half-widths of the plane.
            float halfWidth = scaledWidth / 2f;
            float halfHeight = scaledHeight / 2f;

            // Setup the vertex buffer.
            vertexBuffer[0] = new WireframeShader.Vertex(new Vector3(-halfWidth, halfHeight, 0f), this.LineColor);
            vertexBuffer[1] = new WireframeShader.Vertex(new Vector3(-halfWidth, -halfHeight, 0f), this.LineColor);
            vertexBuffer[2] = new WireframeShader.Vertex(new Vector3(halfWidth, -halfHeight, 0f), this.LineColor);
            vertexBuffer[3] = new WireframeShader.Vertex(new Vector3(halfWidth, halfHeight, 0f), this.LineColor);

            // Check if we are rendering in solid or outline mode.
            if (this.Style == PolygonDrawStyle.Outline)
            {
                // Set the index count.
                this.IndexCount = 8;

                // Build the index buffer.
                indexBuffer[0] = 0;
                indexBuffer[1] = 1;
                indexBuffer[2] = 1;
                indexBuffer[3] = 2;
                indexBuffer[4] = 2;
                indexBuffer[5] = 3;
                indexBuffer[6] = 3;
                indexBuffer[7] = 0;

                // Set the primitive topology to line list.
                this.PrimitiveTopology = SharpDX.Direct3D.PrimitiveTopology.LineList;
            }
            else
            {
                // Set the index count.
                this.IndexCount = 6;

                // Build the index buffer.
                indexBuffer[0] = 0;
                indexBuffer[1] = 3;
                indexBuffer[2] = 2;
                indexBuffer[3] = 2;
                indexBuffer[4] = 1;
                indexBuffer[5] = 0;

                // Set the primitive topology to triangle list.
                this.PrimitiveTopology = SharpDX.Direct3D.PrimitiveTopology.TriangleList;
            }

            // Flag that we are no longer dirty.
            this.IsDirty = false;
        }

        #region IPickableObject

        public void SelectObject(RenderManager manager, object context)
        {
            throw new NotImplementedException();
        }

        public bool DeselectObject(RenderManager manager, object context)
        {
            throw new NotImplementedException();
        }

        public bool DoPickingTest(RenderManager manager, Ray pickingRay, object context, out float distance, out object pickedObjectContext)
        {
            throw new NotImplementedException();
        }

        public bool HandleInput(RenderManager manager)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
