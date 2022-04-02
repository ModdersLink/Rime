using GameToolsDotNet.Rendering.DirectX.Misc;
using GameToolsDotNet.Rendering.DirectX.Shaders;
using SharpDX;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameToolsDotNet.Rendering.DirectX.Gizmos.Polygons
{
    public class LineSegment : Polygon
    {
        private Vector3 point1;
        public Vector3 Point1 { get { return this.point1; } set { this.point1 = value; this.IsDirty = true; } }

        private Vector3 point2;
        public Vector3 Point2 { get { return this.point2; } set { this.point2 = value; this.IsDirty = true; } }

        private Color4 color;
        public Color4 Color { get { return this.color; } set { this.color = value; this.IsDirty = true; } }

        public LineSegment(Vector3 point1, Vector3 point2, Color4 color, Vector3 position, Quaternion rotation)
            : base(2, 2, position, rotation)
        {
            // Initialize fields.
            this.point1 = point1;
            this.point2 = point2;
            this.color = color;

            // Set the primitive topology.
            this.PrimitiveTopology = SharpDX.Direct3D.PrimitiveTopology.LineList;
        }

        public override void BuildMesh(VertexStreamSplice<WireframeShader.Vertex> vertexBuffer, VertexStreamSplice<ushort> indexBuffer)
        {
            // Setup the vertices.
            vertexBuffer[0] = new WireframeShader.Vertex(this.Point1, this.Color);
            vertexBuffer[1] = new WireframeShader.Vertex(this.Point2, this.Color);

            // Setup the indices.
            indexBuffer[0] = 0;
            indexBuffer[1] = 1;

            // Set the number of vertices and indices being used.
            this.VertexCount = 2;
            this.IndexCount = 2;

            // Flag that we are no longer dirty.
            this.IsDirty = false;
        }
    }
}
